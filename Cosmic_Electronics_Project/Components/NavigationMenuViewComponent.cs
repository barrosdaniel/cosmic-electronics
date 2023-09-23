using Microsoft.AspNetCore.Mvc;

namespace Cosmic_Electronics_Project.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "Hello from the Nav View Component";
        }
    }
}