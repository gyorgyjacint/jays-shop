using Jaysbe.Contracts;
using Jaysbe.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;
    private readonly IConfiguration _configuration;

    public AuthController(IAuthService authenticationService, IConfiguration configuration)
    {
        _authService = authenticationService;
        _configuration = configuration;
    }

    [HttpPost]
    public async Task<ActionResult<RegistrationResponse>> Register(RegistrationRequest request)
    {
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
        var result = await _authService.LoginAsync(request.Email, request.Password);

        if (!result.Success)
        {
            AddErrors(result);
            return BadRequest(ModelState);
        }

        return Ok(new AuthResponse(result.Email, result.Username, result.Token));
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
        
        return Ok(new AuthResponse(result.Email, result.Username, result.Token));
    }
}