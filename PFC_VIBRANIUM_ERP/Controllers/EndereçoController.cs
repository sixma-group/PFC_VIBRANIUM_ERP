using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class EnderecoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<EnderecoModel> enderecos = _enderecoRepositorio.BuscarTodos();
            return View(enderecos);
            
        }            

        private readonly IEnderecoRepositorio _enderecoRepositorio;
        public EnderecoController(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            EnderecoModel endereco = _enderecoRepositorio.ListarPoId(id);
            return View(endereco);
        }

        public IActionResult Excluir(int id)
        {
            EnderecoModel endereco = _enderecoRepositorio.ListarPoId(id);
            return View(endereco);
        }
        public IActionResult ExcluirEndereco(int id)
        {
            _enderecoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(EnderecoModel endereco) 
        {
            if(ModelState.IsValid)
            {
                _enderecoRepositorio.Adicionar(endereco);

                return RedirectToAction("Index");
            }

            return View("Index");          
                       
        }

        [HttpPost]
        public IActionResult Alterar(EnderecoModel endereco)
        {
            if (ModelState.IsValid)
            {

                _enderecoRepositorio.Atualizar(endereco);

                return RedirectToAction("Index");               
            }

            return View("Alterar", endereco);
        }
    }
}
