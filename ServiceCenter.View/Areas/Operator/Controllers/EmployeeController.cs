using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee_operator()
        {
            return View();
        }
    }
}
