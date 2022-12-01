using Microsoft.AspNetCore.Mvc;


namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class AcessoController : Controller
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
