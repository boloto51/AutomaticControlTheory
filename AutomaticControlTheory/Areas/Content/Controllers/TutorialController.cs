using Microsoft.AspNetCore.Mvc;

namespace AutomaticControlTheory.Areas.Tutorials.Controllers;

[Area("Content")]
public class TutorialController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}