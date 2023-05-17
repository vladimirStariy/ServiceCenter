using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class TariffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
