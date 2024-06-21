using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Week7_ASPNET.Models;

namespace Week7_ASPNET.Controllers;

[ApiController]
[Route("[controller]")]

public class MainMenuController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Main Menu\n1. View Inventory\n2. Purchase Plant\n3. View Purchase History\n4. Logout\n5. Close Application");
    }

    [HttpGet]
    [Route("(Id)")]
    public IActionResult GetSpecificId(int id)
    {
        Console.WriteLine(id);
        return Ok(id);
    }

    [HttpPost]
    public IActionResult Post(Message message)
    {
        Console.WriteLine(message.note);
        return Created();
    }
}