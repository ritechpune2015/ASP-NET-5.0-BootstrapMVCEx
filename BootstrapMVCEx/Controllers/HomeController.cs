using Microsoft.AspNetCore.Mvc;

namespace BootstrapMVCEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GridSystem()
        {
            return View();
        }


        public IActionResult Typo()
        {
            return View();
        }

        public IActionResult AlertsandButtons()
        {
            return View();
        }
    }
}
