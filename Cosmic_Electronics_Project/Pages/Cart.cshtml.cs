using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cosmic_Electronics_Project.Pages
{
    public class CartModel : PageModel
    {
        [BindProperty]
        public int ProductID { get; set; }

        [BindProperty(Name = "quantity")]
        public int Quantity { get; set; }

        public void OnGet()
        {
        }
    }
}
