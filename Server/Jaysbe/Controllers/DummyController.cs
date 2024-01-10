using Microsoft.AspNetCore.Mvc;

namespace Jaysbe.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class DummyController : ControllerBase
{
    [HttpGet]
    public IActionResult Dummy1()
    {
        return Ok("ok");
    }
}
