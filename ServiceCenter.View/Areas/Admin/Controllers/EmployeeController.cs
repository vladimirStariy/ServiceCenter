using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Employee()
        {
            return View();
        }
    }
}
