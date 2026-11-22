using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
