using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
