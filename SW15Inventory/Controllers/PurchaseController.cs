using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class PurchaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
