using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IEstoqueRepositorio
    {
        List<EstoqueModel> BuscarTodos();

        EstoqueModel ListarPoId(int idItem);

        EstoqueModel Adicionar(EstoqueModel item);

        EstoqueModel Atualizar(EstoqueModel item);

        bool Apagar(int id);

    }
}