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
    public class FornecedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<FornecedorModel> fornecedores = _fornecedorRepositorio.BuscarTodos();
            return View(fornecedores);

        }

        private readonly IFornecedorRepositorio _fornecedorRepositorio;
        public FornecedorController(IFornecedorRepositorio fornecedorRepositorio)
        {
            _fornecedorRepositorio = fornecedorRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            FornecedorModel fornecedor = _fornecedorRepositorio.ListarPoId(id);
            return View(fornecedor);
        }

        public IActionResult Excluir(int id)
        {
            FornecedorModel fornecedor = _fornecedorRepositorio.ListarPoId(id);
            return View(fornecedor);
        }
        public IActionResult ExcluirFornecedor(int id)
        {
            _fornecedorRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {
                _fornecedorRepositorio.Adicionar(fornecedor);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult Alterar(FornecedorModel fornecedor)
        {
            if (ModelState.IsValid)
            {

                _fornecedorRepositorio.Atualizar(fornecedor);

                return RedirectToAction("Index");
            }

            return View("Alterar", fornecedor);
        }
    }
}
