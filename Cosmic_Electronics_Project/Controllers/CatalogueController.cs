﻿using Microsoft.AspNetCore.Mvc;
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

        [Route("Catalogue")]
        [Route("Catalogue/{category}")]
        public IActionResult Index(string category = null)
        {
            ViewBag.pageName = "Catalogue";
            return View(repository.Products
                        .Where(p => category == null || p.Category == category));
        }
	}
}
