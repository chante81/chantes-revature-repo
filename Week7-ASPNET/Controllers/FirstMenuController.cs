using Microsoft.AspNetCore.Mvc;
namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class FirstMenuController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("User Menu\n1. Login\n2. Register");
    }
}
