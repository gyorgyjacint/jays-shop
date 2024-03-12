using AutoMapper;
using Jaysbe.Data;
using Jaysbe.Dtos;
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
    
    public async Task<CategoryResponse[]> GetAll()
    {
        var result = await _context.Categories.Select(c => new CategoryResponse(c)).ToArrayAsync();
        _logger.LogInformation($"{result.Length} categories found");
        return result;
    }

    public async Task<Guid?> Add(Category model)
    {
        var entity = await _context.Categories.AddAsync(model);
        try
        {
            await _context.SaveChangesAsync();
        }
        catch (Exception)
        {
            return null;
        }

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

        var references = _context.Products.Where(p =>  p.Category != null && p.Category.CategoryId == id);
        foreach (var product in references)
        {
            product.Category = null;
        }

        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
        _logger.LogInformation($"Category with ID [{id}] removed");
        
        return category.CategoryId;
    }
    
    public async Task<Guid?> UpdateOrAdd(Category model)
    {
        var dbCategory = await _context.Categories.FindAsync(model.CategoryId);
        
        if (dbCategory?.Name != model.Name && await _context.Categories.AnyAsync(c => c.Name == model.Name))
            return null;

        if (dbCategory == null)
        {
            
            var entityEntry = await _context.Categories.AddAsync(model);
            await _context.SaveChangesAsync();
            
            _logger.LogInformation("Category [{name}] added", model.Name);
            return entityEntry.Entity.CategoryId;
        }
        
        dbCategory.Name = model.Name;
        if (model.Parent != null)
            dbCategory.Parent = model.Parent;
        if (model.ParentId != null)
            dbCategory.ParentId = model.ParentId;
        
        await _context.SaveChangesAsync();
        
        _logger.LogInformation("Category with ID [{id}] updated", dbCategory.CategoryId);
        return dbCategory.CategoryId;
    }
}