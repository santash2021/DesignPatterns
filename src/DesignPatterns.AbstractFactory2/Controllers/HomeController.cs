using DesignPatterns.AbstractFactory2.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AbstractFactory2.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var creator = new Creator(new MsSqlDatabase());
        return Ok();
    }
}