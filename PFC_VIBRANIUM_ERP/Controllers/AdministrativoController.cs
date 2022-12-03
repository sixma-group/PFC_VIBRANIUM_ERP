using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        // Contas a Pagar = CAP

        public IActionResult ListarCAP()
        {

            List<CAPModel> tituloscap = _capRepositorio.BuscarTodos();   

                return View(tituloscap);

        }

        private readonly ICAPRepositorio _capRepositorio;
        public AdministrativoController(ICAPRepositorio capRepositorio)
        {
            _capRepositorio = capRepositorio;

        }

        public IActionResult AlterarCAP(int id)
        {
            CAPModel titulocap = _capRepositorio.ListarPoId(id);
            return View(titulocap);
        }

        public IActionResult ExcluirCAP(int id)
        {
            CAPModel titulocap = _capRepositorio.ListarPoId(id);
            return View(titulocap);
        }
        public IActionResult ExcluirtituloCAP(int id)
        {
            _capRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CadastrarCAP(CAPModel titulocap)
        {
            if (ModelState.IsValid)
            {
                _capRepositorio.Adicionar(titulocap);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult AlterarCAP(CAPModel titulocap)
        {
            if (ModelState.IsValid)
            {

                _capRepositorio.Atualizar(titulocap);

                return RedirectToAction("Index");
            }

            return View("Alterar", titulocap);
        }


        // Contas a Receber = CAR

        public IActionResult ListarCAR()
        {

            List<CARModel> tituloscar = _carRepositorio.BuscarTodos();
            return View(tituloscar);

        }

        private readonly ICARRepositorio _carRepositorio;
        public AdministrativoController(ICARRepositorio carRepositorio)
        {
            _carRepositorio = carRepositorio;

        }

        public IActionResult AlterarCAR(int id)
        {
            CARModel titulocar = _carRepositorio.ListarPoId(id);
            return View(titulocar);
        }

        public IActionResult ExcluirCAR(int id)
        {
            CARModel titulocar = _carRepositorio.ListarPoId(id);
            return View(titulocar);
        }
        public IActionResult ExcluirtituloCAR(int id)
        {
            _carRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CadastrarCAR(CARModel titulocar)
        {
            if (ModelState.IsValid)
            {
                _carRepositorio.Adicionar(titulocar);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult AlterarCAR(CARModel titulocar)
        {
            if (ModelState.IsValid)
            {

                _carRepositorio.Atualizar(titulocar);

                return RedirectToAction("Index");
            }

            return View("Alterar", titulocar);
        }
    }
}
