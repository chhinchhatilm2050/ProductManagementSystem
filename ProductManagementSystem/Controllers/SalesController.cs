using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
