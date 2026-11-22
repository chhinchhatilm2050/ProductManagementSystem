using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
