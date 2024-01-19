using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class DummyController : ControllerBase
{
    [HttpGet]
    public IActionResult Dummy1()
    {
        return Ok("ok");
    }
    
    [Authorize]
    [HttpGet]
    public IActionResult DummyAuth2()
    {
        return Ok("AuthOk");
    }
    
    [Authorize(Roles = "User")]
    [HttpGet]
    public IActionResult DummyUserAuth3()
    {
        return Ok("AuthOk");
    }
    
    [Authorize(Roles = "Admin")]
    [HttpGet]
    public IActionResult DummyAdminAuth4()
    {
        return Ok("AuthOk");
    }
}
