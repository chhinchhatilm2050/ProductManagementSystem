using Microsoft.AspNetCore.Mvc;

namespace SW15Inventory.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
