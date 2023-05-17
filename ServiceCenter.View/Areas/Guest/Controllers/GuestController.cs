using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Guest.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Services()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Tariff()
        {
            return View();
        }
    }
}
