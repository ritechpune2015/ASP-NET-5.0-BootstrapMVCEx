using Microsoft.AspNetCore.Mvc;

namespace BootstrapMVCEx.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
