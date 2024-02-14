using Jaysbe.Data;
using Jaysbe.Models;
using Microsoft.EntityFrameworkCore;

namespace Jaysbe.Services.Repository;

public class CategoryRepository : ICategoryRepository
{
    
    private readonly AppDbContext _context;
    private readonly ILogger<ProductRepository> _logger;

    public CategoryRepository(AppDbContext context, ILogger<ProductRepository> logger)
    {
        _context = context;
        _logger = logger;
    }
    
    public async Task<Category[]> GetAll()
    {
        var result = await _context.Categories.ToArrayAsync();
        _logger.LogInformation($"{result.Length} categories found");
        return result;
    }

    public async Task<Guid?> Add(Category model)
    {
        var entity = await _context.Categories.AddAsync(model);
        await _context.SaveChangesAsync();

        _logger.LogInformation($"{nameof(Add)}, Category entity added to database.");
        return entity.Entity.CategoryId;
    }

    public async Task<Guid?> Delete(Guid id)
    {
        var category = await _context.Categories.FindAsync(id);

        if (category == null)
        {
            _logger.LogInformation($"Category with ID [{id}] not found");
            return null;
        }

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"Category with ID [{id}] removed");
        
        return category.CategoryId;
    }
}