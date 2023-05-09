using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services()
        {
            return View();
        }
    }
}
