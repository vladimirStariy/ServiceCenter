using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Employee.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Order()
        {
            return View();
        }
    }
}
