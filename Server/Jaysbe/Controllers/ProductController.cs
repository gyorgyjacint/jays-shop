using Jaysbe.Contracts;
using Jaysbe.Dtos;
using Jaysbe.Models;
using Jaysbe.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly IProductRepository _repository;

    public ProductController(ILogger<ProductController> logger, IProductRepository repository)
    {
        _logger = logger;
        _repository = repository;
    }

    [HttpPost]
    public async Task<IActionResult> Post([FromForm] ProductRequestDto model)
    {
        _logger.LogInformation(nameof(Post) + $" attempts to register product [{model.Name}]");
        var id = await _repository.Add(model, ModelState);
        return id != null ? Created("name", id) : BadRequest();
    }

    [HttpDelete("{id}")]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult<Guid>> Delete([FromRoute] Guid id)
    {
        _logger.LogInformation(nameof(Delete));
        var result = await _repository.Remove(id);

        return result ? Ok(id) : NotFound();
    }

    [HttpPatch]
    [Authorize(Roles = "Admin")]
    public async Task<ActionResult> Update([FromForm] ProductUpdateRequest model)
    {
        _logger.LogInformation(nameof(Update));
        var id = await _repository.Update(model, ModelState);

        if (id == null)
            return NotFound();
        
        return Ok(id);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Product>> GetById(Guid id)
    {
        _logger.LogInformation(nameof(GetById));
        var product = await _repository.GetById(id);
        return product != null ? Ok(product) : NotFound();
    }

    [HttpGet]
    public async Task<Product[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        return await _repository.GetAll();
    }
}