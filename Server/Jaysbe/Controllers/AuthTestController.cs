using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AuthTestController : ControllerBase
{
    private readonly ILogger<AuthTestController> _logger;

    public AuthTestController(ILogger<AuthTestController> logger)
    {
        _logger = logger;
    }
    
    [HttpGet]
    public IActionResult Status()
    {
        _logger.LogInformation(nameof(Status));
        return Ok();
    }
    
    [Authorize]
    [HttpGet]
    public IActionResult AuthorizedStatus()
    {
        _logger.LogInformation(nameof(AuthorizedStatus));
        return Ok();
    }
    
    [Authorize(Roles = "User")]
    [HttpGet]
    public IActionResult UserAuthorizedStatus()
    {
        _logger.LogInformation(nameof(UserAuthorizedStatus));
        return Ok();
    }
    
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult AdminAuthorizedStatus()
    {
        _logger.LogInformation(nameof(AdminAuthorizedStatus));
        return Ok();
    }
}
