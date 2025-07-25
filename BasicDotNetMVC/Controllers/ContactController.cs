using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicDotNetMVC.Models;

namespace BasicDotNetMVC.Controllers;

public class ContactController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public ContactController(ILogger<HomeController> logger)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
