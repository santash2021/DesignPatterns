using DesignPatterns.FactoryMethod.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.FactoryMethod.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var loadFactory = new LoadFactory();
        var mobileFactory = loadFactory.Load(MobileFactoryType.Nokia);
        var mobile = mobileFactory.CreateMobile();
        return Ok(new
        {
            Model = mobile.GetModel(),
            Price = mobile.GetPrice()
        });
    }
}