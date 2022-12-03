using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<ClienteModel> clientes = _clienteRepositorio.BuscarTodos();
            return View(clientes);
            
        }            

        private readonly IClienteRepositorio _clienteRepositorio;
        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            ClienteModel cliente = _clienteRepositorio.ListarPoId(id);
            return View(cliente);
        }

        public IActionResult Excluir(int id)
        {
            ClienteModel cliente = _clienteRepositorio.ListarPoId(id);
            return View(cliente);
        }
        public IActionResult ExcluirCliente(int id)
        {
            _clienteRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(ClienteModel cliente) 
        {
            if(ModelState.IsValid)
            {
                _clienteRepositorio.Adicionar(cliente);

                return RedirectToAction("Index");
            }

            return View("Index");          
                       
        }

        [HttpPost]
        public IActionResult Alterar(ClienteModel cliente)
        {
            if (ModelState.IsValid)
            {               

                _clienteRepositorio.Atualizar(cliente);

                return RedirectToAction("Index");               
            }

            return View("Alterar", cliente);
        }
    }
}
