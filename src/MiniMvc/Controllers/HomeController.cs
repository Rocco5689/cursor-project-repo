using Microsoft.AspNetCore.Mvc;

namespace MiniMvc.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Message = "Hello from Mini MVC";
        return View();
    }

    public IActionResult Error()
    {
        return View();
    }
}