using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class AcessoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<AcessoModel> acessos = _acessoRepositorio.BuscarTodos();
            return View(acessos);

        }

        private readonly  IAcessoRepositorio _acessoRepositorio;
        public AcessoController(IAcessoRepositorio acessoRepositorio)
        {
            _acessoRepositorio = acessoRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            AcessoModel acesso = _acessoRepositorio.ListarPoId(id);
            return View(acesso);
        }

        public IActionResult Excluir(int id)
        {
            AcessoModel acesso = _acessoRepositorio.ListarPoId(id);
            return View(acesso);
        }
        public IActionResult ExcluirAcesso(int id)
        {
            _acessoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(AcessoModel acesso)
        {
            if (ModelState.IsValid)
            {
                _acessoRepositorio.Adicionar(acesso);

                return RedirectToAction("Index");
            }
                        
            return View("Index");           

        }

        [HttpPost]
        public IActionResult Alterar(AcessoModel acesso)
        {
            if (ModelState.IsValid)
            {

                _acessoRepositorio.Atualizar(acesso);

                return RedirectToAction("Index");
            }

            return View("Alterar", acesso);
        }
    }
}
