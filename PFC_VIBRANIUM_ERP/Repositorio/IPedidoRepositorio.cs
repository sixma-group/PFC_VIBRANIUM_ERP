using PFC_VIBRANIUM_ERP.Models;
using System.Collections.Generic;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IPedidoRepositorio
    {
        List<PedidoModel> BuscarTodos();

        PedidoModel ListarPoId(int idPed);

        PedidoModel Adicionar(PedidoModel pedido);

        PedidoModel Atualizar(PedidoModel pedido);

        bool Apagar(int id);

    }
}