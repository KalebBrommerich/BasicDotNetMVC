using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BasicDotNetMVC.Models;

namespace BasicDotNetMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var slides = new List<HeadlineParagraphImageModel>
    {
        new HeadlineParagraphImageModel
        {
            Headline = "",
            Description = "The ravenous Terminids are guided solely by an instinctive urge to reproduce, spread, and destroy Democracy. They are a fast-evolving plague, a shapeshifting infestation that threatens to devour and disenfranchise every single child on every single planet.",
            BackgroundImageUrl = "/Images/Terminid.png"
        },
        new HeadlineParagraphImageModel
        {
            Headline = "",
            Description = "The Automatons are mindless, bloodthirsty robots, coded for nothing but murder and socialist violence. Their origins are a mystery, but their unthinking hatred of Freedom makes them a threat to all citizens of Super Earth.",
            BackgroundImageUrl = "/Images/Automaton.png"
        },
        new HeadlineParagraphImageModel
        {
            Headline = "",
            Description = "An ancient, “highly advanced” species, desperately seeking to reclaim their former galactic supremacy. These mind-controlling, xenophobic aliens cannot be reasoned with.",
            BackgroundImageUrl = "/Images/Illuminate.png"
        }
    };
        return View(slides);
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
