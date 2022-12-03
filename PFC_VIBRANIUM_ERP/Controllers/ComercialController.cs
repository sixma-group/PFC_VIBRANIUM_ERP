using PFC_VIBRANIUM_ERP.Models;
using PFC_VIBRANIUM_ERP.Repositorio;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Controllers
{
    public class ComercialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<PedidoModel> pedidos = _pedidoRepositorio.BuscarTodos();
            return View(pedidos);

        }

        private readonly IPedidoRepositorio _pedidoRepositorio;
        public ComercialController(IPedidoRepositorio pedidoRepositorio)
        {
            _pedidoRepositorio = pedidoRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            PedidoModel pedido = _pedidoRepositorio.ListarPoId(id);
            return View(pedido);
        }

        public IActionResult Excluir(int id)
        {
            PedidoModel pedido = _pedidoRepositorio.ListarPoId(id);
            return View(pedido);
        }
        public IActionResult ExcluirPedido(int id)
        {
            _pedidoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(PedidoModel pedido)
        {
            if (ModelState.IsValid)
            {
                _pedidoRepositorio.Adicionar(pedido);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult Alterar(PedidoModel pedido)
        {
            if (ModelState.IsValid)
            {

                _pedidoRepositorio.Atualizar(pedido);

                return RedirectToAction("Index");
            }

            return View("Alterar", pedido);
        }
    }
}
