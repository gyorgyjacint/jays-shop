﻿using Jaysbe.Models;
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
    public async Task<IActionResult> Post(Category category)
    {
        _logger.LogInformation(nameof(Post));
        var result = await _repository.Add(category);
        return result != null ? Created() : BadRequest();
    }

    [HttpGet]
    public async Task<Category[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        var result = await _repository.GetAll();
        return result;
    }

    [HttpDelete]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> Delete(Guid id)
    {
        _logger.LogInformation(nameof(Delete));
        var result = await _repository.Delete(id);
        return result != null ? Ok(result) : NotFound(id);
    }

}