﻿using Microsoft.AspNetCore.Mvc;

namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class AdministrativoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
