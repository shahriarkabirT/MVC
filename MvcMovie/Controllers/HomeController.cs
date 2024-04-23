using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult Buy()
    {
        return View();
    }
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Login(LoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            // Replace these with your predefined username and password
            string correctUsername = "shahriar";
            string correctPassword = "123";

            if (model.Username == correctUsername && model.Password == correctPassword)
            {
                return RedirectToAction("AnotherPage");
            }
            else
            {
                ViewBag.ErrorMessage = "Invalid username or password.";
            }
        }

        return View("Index", model);
    }

    public ActionResult AnotherPage()
    {
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

