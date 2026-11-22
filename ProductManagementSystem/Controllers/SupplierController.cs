using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
