using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Shoes_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
