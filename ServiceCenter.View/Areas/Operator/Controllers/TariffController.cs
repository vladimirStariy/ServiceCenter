using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class TariffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
