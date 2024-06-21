using Microsoft.AspNetCore.Mvc;

namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello");
    }
}