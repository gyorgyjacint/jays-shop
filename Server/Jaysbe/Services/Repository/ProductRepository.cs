﻿using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Data;
using Jaysbe.Dtos;
using Jaysbe.Models;
using Jaysbe.Services.File;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace Jaysbe.Services.Repository;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;
    private readonly IProductImageService _productImageService;
    private readonly IMapper _mapper;
    private readonly ILogger<ProductRepository> _logger;

    public ProductRepository(AppDbContext context, IProductImageService productImageService, IMapper mapper, ILogger<ProductRepository> logger)
    {
        _context = context;
        _productImageService = productImageService;
        _mapper = mapper;
        _logger = logger;
    }

    public async Task<Product[]> GetAll()
    {
        if (_context.Products.IsNullOrEmpty())
        {
            _logger.LogInformation($"{nameof(GetAll)}: no products found");
            return Array.Empty<Product>();
        }

        var products = await _context.Products.ToArrayAsync();
        _logger.LogInformation($"{nameof(GetAll)}: {products.Length} products found");
        return products;
    }

    public async Task<Product?> GetById(Guid id)
    {
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);

        if (product is null)
        {
            _logger.LogInformation($"Product with ID: [{id}] not found");
            return null;
        }

        return product;
    }

    public async Task<bool> Remove(Guid id)
    {
         var product = await _context.Products.FindAsync(id);

         if (product is null)
         {
             _logger.LogInformation($"Product with ID [{id}] not found");
            return false;
         }

         _context.Remove(product);
         await _context.SaveChangesAsync();

         _logger.LogInformation($"Product with ID [{product.ProductId}] deleted");

         return true;
    }

    public async Task<Guid?> Add(ProductRequestDto model, ModelStateDictionary modelState)
    {
        var mappedProduct = _mapper.Map<Product>(model);

        var thumbnailResult = await _productImageService.AddImageAsync(model.Thumbnail, modelState);

        if (thumbnailResult.isSuccessful)
        {
            mappedProduct.ThumbnailUrl = thumbnailResult.path;
        }
        else
        {
            _logger.LogInformation(
                $"Register of product [{model.Name}] is unsuccessful, {nameof(thumbnailResult.isSuccessful)} is false");
        }

        if (model.Pictures != null)
        {
            var picsResult = await _productImageService.AddImagesAsync(model.Pictures, modelState);
            if (picsResult.paths.Any())
                mappedProduct.PicturesUrls = picsResult.paths.ToList();

            _logger.LogInformation($"Saved [{picsResult.paths.Count()}] out of {model.Pictures.Count} images");
        }

        var entityEntry = await _context.Products.AddAsync(mappedProduct);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"{mappedProduct.Name} product added to database");
        return entityEntry.Entity.ProductId;
    }

    public async Task<Guid?> Update(ProductUpdateRequest model, ModelStateDictionary modelState)
    {
        var product = await _context.Products.FindAsync(model.ProductId);

        if (product is null)
            return null;

        if (model.PicturesUrls != null &&
            (model.PicturesUrls.Any(u => u == null!) || model.PicturesUrls.Any(u => u == "null")))
        {
            var control = model.PicturesUrls.Where(u => u != "null" && u != null!).ToArray();
            model.PicturesUrls = control.Length > 0 ? control : null;
        }

        if (model.ThumbnailUrl == "null")
            model.ThumbnailUrl = null;

        if (product.ThumbnailUrl != null && (model.ThumbnailUrl == null || product.ThumbnailUrl.Length < 1))
            _productImageService.RemoveFile(product.ThumbnailUrl);

        if (product.PicturesUrls != null &&
            product.PicturesUrls.Count > (model.PicturesUrls?.Count ?? 0))
        {
            var accessRoutesToRemove = (model.PicturesUrls == null || !model.PicturesUrls.Any()
                    ? product.PicturesUrls
                    : product.PicturesUrls.Where(u => !model.PicturesUrls.Contains(u)))
                .ToArray();

            if (accessRoutesToRemove.Length > 0)
            {
                foreach (var accessRoute in accessRoutesToRemove)
                {
                    var result = _productImageService.RemoveFile(accessRoute);
                }
            }
        }

        if (model.ThumbnailNew != null)
        {
            var result = await _productImageService.AddImageAsync(model.ThumbnailNew, modelState);
            if (result.isSuccessful)
                model.ThumbnailUrl = result.path;
            
            if (result.isSuccessful && product.ThumbnailUrl != null)
                _productImageService.RemoveFile(product.ThumbnailUrl);
        }

        if (model.PicturesNew != null || model.PicturesNew?.Count > 0)
        {
            var result = await _productImageService.AddImagesAsync(model.PicturesNew, modelState);
            if (result.paths.Any())
            {
                var paths = result.paths.Where(s => !string.IsNullOrEmpty(s));
                model.PicturesUrls = (model.PicturesUrls != null
                    ? model.PicturesUrls.Concat(paths)
                    : paths).ToList();
            }
        }

        _context.Entry(product).CurrentValues.SetValues(model);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"Product with ID [{product.ProductId}] updated");

        return model.ProductId;
    }
}