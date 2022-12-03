using PFC_VIBRANIUM_ERP.Models;
using System.Collections.Generic;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IProdutoRepositorio
    {
        List<ProdutoModel> BuscarTodos();

        ProdutoModel ListarPoId(int idProd);

        ProdutoModel Adicionar(ProdutoModel produto);

        ProdutoModel Atualizar(ProdutoModel produto);

        bool Apagar(int id);

    }
}