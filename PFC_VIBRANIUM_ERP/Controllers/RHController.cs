using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class RHController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<FuncionarioModel> funcionarios = _funcionarioRepositorio.BuscarTodos();
            return View(funcionarios);

        }

        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public RHController(IFuncionarioRepositorio funconarioRepositorio)
        {
            _funcionarioRepositorio = funconarioRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPoId(id);
            return View(funcionario);
        }

        public IActionResult Excluir(int id)
        {
            FuncionarioModel funcionario = _funcionarioRepositorio.ListarPoId(id);
            return View(funcionario);
        }
        public IActionResult ExcluirFuncionario(int id)
        {
            _funcionarioRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(FuncionarioModel funcionario)
        {
            if (ModelState.IsValid)
            {
                _funcionarioRepositorio.Adicionar(funcionario);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult Alterar(FuncionarioModel funcionario)
        {
            if (ModelState.IsValid)
            {

                _funcionarioRepositorio.Atualizar(funcionario);

                return RedirectToAction("Index");
            }

            return View("Alterar", funcionario);
        }
    }
}
