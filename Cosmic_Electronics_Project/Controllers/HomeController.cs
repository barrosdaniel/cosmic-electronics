using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Electronics_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.pageName = "Home";
            return View();
        }
    }
}
