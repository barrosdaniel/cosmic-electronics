using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Shoes_Project.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
