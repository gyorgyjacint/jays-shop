using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Data;
using Jaysbe.Models;
using Jaysbe.Services.File;
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

    public ProductController(AppDbContext context, IMapper mapper, IImageUploadHandler imageUploadHandler, ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
        _imageUploadHandler = imageUploadHandler;
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromForm]ProductRequest product)
    {
        _logger.LogInformation($"{nameof(Post)}, {product.Name}");
        var mappedProduct = _mapper.Map<Product>(product);
        
        var thumbnailResult = await _imageUploadHandler.AddImageAsync(product.Thumbnail, ModelState);
        if (!thumbnailResult.isSuccessful)
        {
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
        }
        
        await _context.Products.AddAsync(mappedProduct);
        _logger.LogInformation($"{mappedProduct.Name} product added to database");
        await _context.SaveChangesAsync();
        return Created("name", mappedProduct.Name);
    }

    [HttpGet]
    public async Task<Product> GetFirst()
    {
        var item = await _context.Products.FirstAsync();
        return item;
    }
}