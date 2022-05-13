using DesignPatterns.AbstractFactory.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.AbstractFactory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MobileController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var loadFactory = new LoadFactory();
        var factory = loadFactory.Load(LoadFactoryType.Sensor);
        var mobile = factory.CreateAndroidMobile();
        
        return Ok(new
        {
            Model = mobile.CreateAndroidMobile()
        });
    }
}