using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ProdutoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ProdutoModel ListarPoId(int id)
        {
            return _bancoContext.Produto.FirstOrDefault(x => x.idProd == id);
        }
        public List<ProdutoModel> BuscarTodos()
        {
            return _bancoContext.Produto.ToList();
        }

        public ProdutoModel Adicionar(ProdutoModel produto)
        {
            Console.WriteLine("dadossss  " + produto);

            //Gravar no banco de dados
            _bancoContext.Produto.Add(produto);
            _bancoContext.SaveChanges();
            return produto;
        }

        public ProdutoModel Atualizar(ProdutoModel produto)
        {

            ProdutoModel produtoDB = ListarPoId(produto.idProd);


            if (produtoDB == null) throw new Exception("Houve um erro na atualização do Produto!");

            produtoDB.nome = produto.nome;
            produtoDB.valor_aquisicao = produto.valor_aquisicao;
            produtoDB.preco_saida = produto.preco_saida;
            produtoDB.itens = produto.itens;
            produtoDB.descricao = produto.descricao;
            produtoDB.idItem = produto.idItem;


            _bancoContext.Produto.Update(produtoDB);
            _bancoContext.SaveChanges();

            return produtoDB;

        }

        public bool Apagar(int id)
        {
            ProdutoModel produtoDB = ListarPoId(id);

            if (produtoDB == null) throw new Exception("Houve um erro na excluão do registro de Produto!");
            _bancoContext.Produto.Remove(produtoDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
