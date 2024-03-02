using Jaysbe.Dtos;
using Jaysbe.Services.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]/")]
public class UserController : ControllerBase
{
    private readonly ILogger<UserController> _logger;
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository, ILogger<UserController> logger)
    {
        _logger = logger;
        _repository = repository;
    }

    [Authorize(Roles = "Admin")]
    [HttpGet]
    public async Task<UserDto<Guid>[]> GetAll()
    {
        _logger.LogInformation(nameof(GetAll));
        return await _repository.GetAll();
    }
    
    [Authorize(Roles = "Admin")]
    [HttpDelete("{userId}")]
    public async Task<IActionResult> Delete([FromRoute] Guid userId)
    {
        _logger.LogInformation(nameof(Delete));
        var result = await _repository.Delete(userId);
        return result != null ? Ok(result) : BadRequest();
    }

    [Authorize(Roles = "Admin")]
    [HttpPatch]
    public async Task<IActionResult> Update([FromBody]UserDto<string> user)
    {
        _logger.LogInformation(nameof(Update));
        var result = await _repository.Update(user);
        return result != null ? Ok(result) : BadRequest();
    }

    [Authorize(Roles = "Admin")]
    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto<string>>> GetById([FromRoute] string id)
    {
        _logger.LogInformation(nameof(GetById));
        var result = await _repository.GetById(id);
        return result != null ? Ok(result) : NotFound();
    }
}