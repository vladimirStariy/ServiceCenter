using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Reports()
        {
            return View();
        }
    }
}
