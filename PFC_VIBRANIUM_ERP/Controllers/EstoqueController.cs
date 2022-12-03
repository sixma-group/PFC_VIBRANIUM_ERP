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
    public class EstoqueController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<EstoqueModel> itens = _estoqueRepositorio.BuscarTodos();
            return View(itens);

        }

        private readonly IEstoqueRepositorio _estoqueRepositorio;
        public EstoqueController(IEstoqueRepositorio estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            EstoqueModel item = _estoqueRepositorio.ListarPoId(id);
            return View(item);
        }

        public IActionResult Excluir(int id)
        {
            EstoqueModel item = _estoqueRepositorio.ListarPoId(id);
            return View(item);
        }
        public IActionResult ExcluirItem(int id)
        {
            _estoqueRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(EstoqueModel item)
        {
            if (ModelState.IsValid)
            {
                _estoqueRepositorio.Adicionar(item);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult Alterar(EstoqueModel item)
        {
            if (ModelState.IsValid)
            {

                _estoqueRepositorio.Atualizar(item);

                return RedirectToAction("Index");
            }

            return View("Alterar", item);
        }
    }
}
