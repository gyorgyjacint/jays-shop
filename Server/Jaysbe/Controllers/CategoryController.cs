using Jaysbe.Dtos;
using Jaysbe.Models;
using Jaysbe.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CategoryController : ControllerBase
{
    private readonly ICategoryRepository _repository;
    private readonly ILogger<CategoryController> _logger;
    
    public CategoryController(ICategoryRepository repository, ILogger<CategoryController> logger)
    {
        _repository = repository;
        _logger = logger;
    }
    
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Post([FromBody]Category category)
    {
        _logger.LogInformation(nameof(Post));
        var result = await _repository.Add(category);
        return result != null ? Created(nameof(Post), result.ToString()) : BadRequest();
    }

    [HttpGet]
    public async Task<CategoryResponse[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        var result = await _repository.GetAll();
        return result;
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> Delete(Guid id)
    {
        _logger.LogInformation(nameof(Delete));
        var result = await _repository.Delete(id);
        return result != null ? Ok(result) : NotFound(id);
    }
    
    [HttpPatch]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> Update(Category category)
    {
        _logger.LogInformation(nameof(Update));
        var result = await _repository.UpdateOrAdd(category);
        return result != null ? Ok(result) : BadRequest(category.Name);
    }

}