using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
