using Microsoft.AspNetCore.Mvc;


namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class AdministrativoController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexCAP()
        {
            return View("~/Views/Administrativo/CAP/Index.cshtml");
        }

        public IActionResult IndexCAR()
        {
            return View("~/Views/Administrativo/CAR/Index.cshtml");
        }

        public IActionResult CadastrarCAP()
        {
            return View("~/Views/Administrativo/CAP/Cadastrar.cshtml");
        }

        public IActionResult CadastrarCAR()
        {
            return View("~/Views/Administrativo/CAR/Cadastrar.cshtml");
        }
    }
}
