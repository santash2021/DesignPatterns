using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.FactoryMethod.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok();
    }
}