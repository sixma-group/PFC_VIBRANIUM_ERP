using PFC_VIBRANIUM_ERP.Controllers;
using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class PedidoRepositorio : IPedidoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public PedidoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public PedidoModel ListarPoId(int id)
        {
            return _bancoContext.Pedido.FirstOrDefault(x => x.idPed == id);
        }
        public List<PedidoModel> BuscarTodos()
        {
            return _bancoContext.Pedido.ToList();
        }

        public PedidoModel Adicionar(PedidoModel pedido)
        {
            //Gravar no banco de dados
            _bancoContext.Pedido.Add(pedido);
            _bancoContext.SaveChanges();
            return pedido;
        }

        public PedidoModel Atualizar(PedidoModel pedido)
        {

            PedidoModel pedidoDB = ListarPoId(pedido.idPed);


            if (pedidoDB == null) throw new Exception("Houve um erro na atualização do Pedido!");

            pedidoDB.tipo = pedido.tipo;
            pedidoDB.produtos = pedido.produtos;
            pedidoDB.dtPedido = pedido.dtPedido;
            pedidoDB.quantidade = pedido.quantidade;
            pedidoDB.valor = pedido.valor;
            pedidoDB.status = pedido.status;
            pedidoDB.idCli = pedido.idCli;
            pedidoDB.idForn = pedido.idForn;


            _bancoContext.Pedido.Update(pedidoDB);
            _bancoContext.SaveChanges();

            return pedidoDB;

        }

        public bool Apagar(int id)
        {
            PedidoModel pedidoDB = ListarPoId(id);

            if (pedidoDB == null) throw new Exception("Houve um erro na excluão do registro de Pedido!");
            _bancoContext.Pedido.Remove(pedidoDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
