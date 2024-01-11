using Jaysbe.Contracts;
using Jaysbe.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authenticationService)
    {
        _authService = authenticationService;
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
}