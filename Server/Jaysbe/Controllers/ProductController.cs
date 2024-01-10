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

    public ProductController(AppDbContext context, ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(Product product)
    {
        _logger.LogInformation($"{nameof(Post)}, ");
        
        var entity = await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return Ok();
    }

    [HttpGet]
    public async Task<Product> GetFirst()
    {
        var item = await _context.Products.FirstAsync();
        return item;
    }
}