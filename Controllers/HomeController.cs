using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


// Hadley Garff 4-14
namespace Mission5.Controllers
{
    public class HomeController : Controller
    {
        // This is the view to the Index which is the hobby main view.
        public IActionResult Index()
        {
            return View();
        }

        // This is the view to the simple calculator for services.
        public IActionResult Calculator()
        {
            return View();
        }

    }
}
