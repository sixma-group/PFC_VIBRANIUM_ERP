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
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Listar()
        {

            List<ProdutoModel> produtos = _produtoRepositorio.BuscarTodos();
            return View(produtos);

        }

        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;

        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPoId(id);
            return View(produto);
        }

        public IActionResult Excluir(int id)
        {
            ProdutoModel produto = _produtoRepositorio.ListarPoId(id);
            return View(produto);
        }
        public IActionResult ExcluirProduto(int id)
        {
            _produtoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Cadastrar(ProdutoModel produto)
        {
            Console.WriteLine(produto.preco_saida + " aaa " + produto.valor_aquisicao + " aaa "
                + produto.descricao + " aaa " + produto.itens + " aaa " + produto.nome + " aaa " + produto.idItem + " aaa ");

            if (ModelState.IsValid)
            {

                
                _produtoRepositorio.Adicionar(produto);

                return RedirectToAction("Index");
            }

            return View("Index");

        }

        [HttpPost]
        public IActionResult Alterar(ProdutoModel produto)
        {
            

            if (ModelState.IsValid)
            {
                
                _produtoRepositorio.Atualizar(produto);

                return RedirectToAction("Index");
            }

            return View("Alterar", produto);
        }
    }
}
