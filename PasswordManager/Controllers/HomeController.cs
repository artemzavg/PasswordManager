using Microsoft.AspNetCore.Mvc;

namespace PasswordManager.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}