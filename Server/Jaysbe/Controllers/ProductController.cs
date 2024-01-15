using AutoMapper;
using Jaysbe.Contracts;
using Jaysbe.Data;
using Jaysbe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<ProductController> _logger;
    private readonly IMapper _mapper;

    public ProductController(AppDbContext context, IMapper mapper, ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
        _mapper = mapper;
    }
    
    [HttpPost]
    public async Task<IActionResult> Post([FromForm]ProductRequest product)
    {
        _logger.LogInformation($"{nameof(Post)}, {product.Name}");
        IList<string> allowedFileExtensions = new List<string> { ".jpg", ".jpeg", ".png" };
        int maxContentSize = 1024 * 1024 * 10; //10mb
        var mappedProduct = _mapper.Map<Product>(product);
        
        if (product.Thumbnail.Length > 0)
        {
            var ext = product.Thumbnail.FileName.Substring(product.Thumbnail.FileName.LastIndexOf('.'));
            var extension = ext.ToLower();
            
            if (!allowedFileExtensions.Contains(extension))
                return BadRequest("Invalid file extension.");
            if (product.Thumbnail.Length > maxContentSize)
                return BadRequest("File too large");
            
            var path = "Pics";
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            var filePath = Path.Combine(path, Guid.NewGuid() + extension);

            await using (var stream = System.IO.File.Create(filePath))
            {
                await product.Thumbnail.CopyToAsync(stream);
            }
            mappedProduct.ThumbnailUrl = filePath;
        }

        if (product.Pictures != null)
        {
            if(product.Pictures != null && !product.Pictures.Any(f => 
                   allowedFileExtensions.Contains(f.FileName.Substring(product.Thumbnail.FileName.LastIndexOf('.')).ToLower())))
                return BadRequest("Invalid file extension.");
            if (product.Pictures != null && product.Pictures.Any(f => f.Length > maxContentSize))
                return BadRequest("File too large");
            
            foreach (var formFile in product.Pictures)
            {
                var extension = product.Thumbnail.FileName.Substring(product.Thumbnail.FileName.LastIndexOf('.')).ToLower();
                
                if (formFile.Length > 0)
                {
                    var path = "Pics";
                    
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    var filePath = Path.Combine(path, Guid.NewGuid() + extension);

                    await using (var stream = System.IO.File.Create(filePath))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                    mappedProduct.PicturesUrls ??= new List<string>();

                    mappedProduct.PicturesUrls.Add(filePath);
                }
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