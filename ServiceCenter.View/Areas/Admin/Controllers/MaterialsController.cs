using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class MaterialsController : Controller
    {
        public IActionResult Materials()
        {
            return View();
        }
    }
}
