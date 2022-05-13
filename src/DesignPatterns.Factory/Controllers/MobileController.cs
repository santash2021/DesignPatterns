using DesignPatterns.Factory.Factories;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatterns.Factory.Controllers;

[ApiController]
[Route("api/[controller]")]
public class MobileController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var mobileFactory = new MobileFactory();
        var mobile = mobileFactory.GetMobile(MobileModel.Samsung);
        return Ok(new
        {
            Model = mobile?.GetModel(),
            Price = mobile?.GetPrice()
        });
    }
}