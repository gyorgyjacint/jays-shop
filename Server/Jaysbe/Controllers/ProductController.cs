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
    private readonly IImageUploadHandler _imageUploadHandler;

    public ProductController(AppDbContext context, IMapper mapper, IImageUploadHandler imageUploadHandler,
        ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
        _imageUploadHandler = imageUploadHandler;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromForm] ProductRequestDto product)
    {
        _logger.LogInformation(nameof(Post));
        _logger.LogInformation($"Attempt to register product [{product.Name}]");
        var mappedProduct = _mapper.Map<Product>(product);

        var thumbnailResult = await _imageUploadHandler.AddImageAsync(product.Thumbnail, ModelState);
        if (!thumbnailResult.isSuccessful)
        {
            _logger.LogInformation(
                $"Register of product [{product.Name}] is unsuccessful, {nameof(thumbnailResult.isSuccessful)} is false");
            return BadRequest(thumbnailResult.errorMessages);
        }

        mappedProduct.ThumbnailUrl = thumbnailResult.path;

        if (product.Pictures != null)
        {
            var picsResult = await _imageUploadHandler.AddImagesAsync(product.Pictures, ModelState);
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

    [HttpPatch]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Guid>> Update([FromBody] Product model)
    {
        var product = await _context.Products.FindAsync(model.ProductId);

        if (product is null)
            return BadRequest();

        _context.Entry(product).CurrentValues.SetValues(model);
        await _context.SaveChangesAsync();
        
        return Ok(product.ProductId);
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