using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "Hello from Docker!" });
    }
}