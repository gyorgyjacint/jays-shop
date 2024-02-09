using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Data;
using Jaysbe.Models;
using Jaysbe.Services.File;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<ProductController> _logger;
    private readonly IMapper _mapper;
    private readonly IProductImageService _productImageService;

    public ProductController(AppDbContext context, IMapper mapper, IProductImageService productImageService,
        ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
        _productImageService = productImageService;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromForm] ProductRequestDto product)
    {
        _logger.LogInformation(nameof(Post));
        _logger.LogInformation($"Attempt to register product [{product.Name}]");
        var mappedProduct = _mapper.Map<Product>(product);

        var thumbnailResult = await _productImageService.AddImageAsync(product.Thumbnail, ModelState);
        if (!thumbnailResult.isSuccessful)
        {
            _logger.LogInformation(
                $"Register of product [{product.Name}] is unsuccessful, {nameof(thumbnailResult.isSuccessful)} is false");
            return BadRequest(thumbnailResult.errorMessages);
        }

        mappedProduct.ThumbnailUrl = thumbnailResult.path;

        if (product.Pictures != null)
        {
            var picsResult = await _productImageService.AddImagesAsync(product.Pictures, ModelState);
            if (picsResult.paths.Any())
            {
                mappedProduct.PicturesUrls = (IList<string>?)picsResult.paths;
            }

            _logger.LogInformation($"Saved [{picsResult.paths.Count()}] out of {product.Pictures.Count} images");
        }

        await _context.Products.AddAsync(mappedProduct);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"{mappedProduct.Name} product added to database");
        return Created("name", mappedProduct.Name);
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Guid>> Delete([FromRoute] Guid id)
    {
        _logger.LogInformation(nameof(Delete));
        var product = await _context.Products.FindAsync(id);

        if (product is null)
            return BadRequest();

        _context.Remove(product);
        await _context.SaveChangesAsync();

        _logger.LogInformation($"Product with ID [{product.ProductId}] deleted");
        return Ok(product.ProductId);
    }

    [HttpPatch]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<(Guid id, int errorCount)>> Update([FromForm] ProductUpdateRequest model)
    {
        _logger.LogInformation(nameof(Update));
        var product = await _context.Products!.FindAsync(model.ProductId);

        if (product is null)
            return BadRequest();

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
            var result = await _productImageService.AddImageAsync(model.ThumbnailNew, ModelState);
            if (result.isSuccessful)
                model.ThumbnailUrl = result.path;
            
            if (result.isSuccessful && product.ThumbnailUrl != null)
                _productImageService.RemoveFile(product.ThumbnailUrl);
        }

        if (model.PicturesNew != null || model.PicturesNew?.Count > 0)
        {
            var result = await _productImageService.AddImagesAsync(model.PicturesNew, ModelState);
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
        return Ok(new { id = product.ProductId, errorCount = ModelState.ErrorCount });
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(Guid id)
    {
        _logger.LogInformation(nameof(GetById));
        var product = await _context.Products.FirstOrDefaultAsync(p => p.ProductId == id);

        if (product is null)
        {
            _logger.LogInformation($"Product with ID: [{id}] not found");
            return NotFound();
        }

        return Ok(product);
    }

    [HttpGet]
    public async Task<Product[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));

        if (_context.Products == null)
        {
            _logger.LogInformation($"{nameof(GetAll)}: no products found");
            return Array.Empty<Product>();
        }

        var products = await _context.Products.ToArrayAsync();
        _logger.LogInformation($"{nameof(GetAll)}: {products.Length} products found");

        return products;
    }
}