﻿using Microsoft.AspNetCore.Mvc;

namespace ServiceCenter.View.Areas.Operator.Controllers
{
    public class TariffController : Controller
    {
        public IActionResult Tariff_operator()
        {
            return View();
        }
    }
}
