using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
