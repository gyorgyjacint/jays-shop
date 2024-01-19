using Jaysbe.Data;
using Jaysbe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CategoryController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly ILogger<CategoryController> _logger;
    
    public CategoryController(AppDbContext context, ILogger<CategoryController> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(Category category)
    {
        _logger.LogInformation($"{nameof(Post)}, called.");
        
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();

        _logger.LogInformation($"{nameof(Post)}, Category entity added to database.");
        return Created();
    }

    [HttpGet]
    public async Task<Category> GetFirst()
    {
        var item = await _context.Categories.FirstAsync();
        return item;
    }
}