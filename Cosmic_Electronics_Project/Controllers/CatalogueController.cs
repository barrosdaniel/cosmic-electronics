using Cosmic_Electronics_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Electronics_Project.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
			ViewBag.pageName = "Catalogue";
            return View();
        }
	}
}
