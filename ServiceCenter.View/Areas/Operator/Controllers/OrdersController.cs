using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Orders()
        {
            return View();
        }
    }
}
