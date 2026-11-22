using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
