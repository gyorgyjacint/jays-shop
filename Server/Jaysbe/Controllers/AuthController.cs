using Jaysbe.Contracts;
using Jaysbe.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IConfiguration _configuration;
    private readonly ILogger<AuthController> _logger;

    public AuthController(IAuthService authenticationService, ILogger<AuthController> logger, IConfiguration configuration)
    {
        _authService = authenticationService;
        _logger = logger;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
    {
        _logger.LogInformation(nameof(Register));
        var result = await _authService.RegisterAsync(request.Email, request.UserName, request.Password, "User");

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        return CreatedAtAction(nameof(Register), new RegistrationResponse(result.Email, result.Username));
    }
    
    [HttpPost]
    public async Task<ActionResult<AuthResponse>> Authenticate([FromBody] AuthRequest request)
    {
        _logger.LogInformation(nameof(Authenticate));
        var result = await _authService.LoginAsync(request.Email, request.Password);

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        Response.Cookies.Append(
            "Authorization",
            result.Token,
            new CookieOptions
            {
                HttpOnly = true
            }
        );
        return Ok(new AuthResponse(result.Email, result.Username, null));
    }
    
    private void AddErrors(AuthResult result)
    {
        foreach (var error in result.ErrorMessages)
        {
            ModelState.AddModelError(error.Key, error.Value);
        }
    }
    
    [HttpPost]
    public async Task<ActionResult<AuthResponse>> AuthenticateAdmin([FromBody] AuthRequest request)
    {
        _logger.LogInformation(nameof(AuthenticateAdmin));
        if (request.Email != _configuration["AdminEmail"])
        {
            ModelState.AddModelError("auth-error", "Unauthorized");
            return Unauthorized(ModelState);
        }
        
        var result = await _authService.LoginAsync(request.Email, request.Password);
        
        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        Response.Cookies.Append(
            "Authorization",
            result.Token,
            new CookieOptions
            {
                HttpOnly = true
            }
        );
        return Ok(new AuthResponse(result.Email, result.Username, null));
    }
}