using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Guest.Controllers
{
    public class GuestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
