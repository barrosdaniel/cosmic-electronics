using Cosmic_Electronics_Project.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Electronics_Project.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
			ViewBag.pageName = "Catalogue";
            return View(SampleData());
        }

		public List<Product> SampleData()
		{
			List<Product> Products = new List<Product>();

			Products.Add(new Product
			{
				Name = "Acer Laptop",
				Description = "Acer Laptop Windows 11",
				Category = "Computers",
				Price = 1599,
				Image = "product1.png"
			});
			Products.Add(new Product
			{
				Name = "MSI Laptop",
				Description = "MSI Laptop Windows 11",
				Category = "Computers",
				Price = 1949,
				Image = "product2.png"
			});
			Products.Add(new Product
			{
				Name = "Microsoft Surface Pro",
				Description = "Surface tablet",
				Category = "Computers",
				Price = 2199,
				Image = "product3.png"
			});
			Products.Add(new Product
			{
				Name = "Sumsung TV",
				Description = "Samsung OLED TV",
				Category = "Television",
				Price = 3295,
				Image = "product4.png"
			});
			Products.Add(new Product
			{
				Name = "LG TV",
				Description = "LG OLED TV",
				Category = "Television",
				Price = 3045,
				Image = "product5.png"
			});
			Products.Add(new Product
			{
				Name = "XBOX Wireless Controller",
				Description = "XBOX Wireless Controller",
				Category = "Gaming",
				Price = 499,
				Image = "product6.png"
			});
			Products.Add(new Product
			{
				Name = "Samsung S23 Ultra",
				Description = "Samsung S23 Ultra mobile phone",
				Category = "Mobiles",
				Price = 1949,
				Image = "product7.png"
			});
			Products.Add(new Product
			{
				Name = "Apple AirPods",
				Description = "Apple AirPods Pro",
				Category = "Mobiles",
				Price = 339,
				Image = "product8.png"
			});
			Products.Add(new Product
			{
				Name = "Acer Laptop",
				Description = "Acer Laptop Windows 11",
				Category = "Computers",
				Price = 1599,
				Image = "product1.png"
			});

			return Products;
		}
	}
}
