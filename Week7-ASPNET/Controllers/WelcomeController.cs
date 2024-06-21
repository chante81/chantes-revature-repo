using Microsoft.AspNetCore.Mvc;

namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]
public class WelcomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Welcome!!");
    }
}

