using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        private readonly BancoContext _bancoContext;

        public EstoqueRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public EstoqueModel ListarPoId(int id)
        {
            return _bancoContext.Estoque.FirstOrDefault(x => x.idItem == id);
        }
        public List<EstoqueModel> BuscarTodos()
        {
            return _bancoContext.Estoque.ToList();
        }

        public EstoqueModel Adicionar(EstoqueModel item)
        {
            //Gravar no banco de dados
            _bancoContext.Estoque.Add(item);
            _bancoContext.SaveChanges();
            return item;
        }

        public EstoqueModel Atualizar(EstoqueModel item)
        {

            EstoqueModel itemDB = ListarPoId(item.idItem);


            if (itemDB == null) throw new Exception("Houve um erro na atualização do Item!");

            itemDB.nome = item.nome;
            itemDB.preco = item.preco;
            itemDB.marca = item.marca;
            itemDB.descricao = item.descricao;
            itemDB.quantidade = item.quantidade;

            _bancoContext.Estoque.Update(itemDB);
            _bancoContext.SaveChanges();

            return itemDB;

        }

        public bool Apagar(int id)
        {
            EstoqueModel itemDB = ListarPoId(id);

            if (itemDB == null) throw new Exception("Houve um erro na excluão do registro de Item!");
            _bancoContext.Estoque.Remove(itemDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
