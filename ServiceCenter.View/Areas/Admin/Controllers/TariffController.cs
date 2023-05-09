using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Admin.Controllers
{
    public class TariffController : Controller
    {
        [HttpGet]
        public IActionResult Tariff()
        {
            return View();
        }

        [HttpPost]
        public void TariffEdit(string mode, string TariffViewModel)
        { 
            if(mode == "add")
            {

            }
            else
            {

            }
        }
    }
}
