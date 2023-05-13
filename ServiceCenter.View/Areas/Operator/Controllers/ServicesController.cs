using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Services_operator()
        {
            return View();
        }
    }
}
