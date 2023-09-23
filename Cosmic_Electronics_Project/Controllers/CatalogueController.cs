using Microsoft.AspNetCore.Mvc;
using Cosmic_Electronics_Project.Models;

namespace Cosmic_Electronics_Project.Controllers
{
    public class CatalogueController : Controller
    {
        private IStoreRepository repository;

        public CatalogueController(IStoreRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Products);
	}
}
