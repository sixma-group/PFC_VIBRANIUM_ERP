using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface ICARRepositorio
    {
        List<CARModel> BuscarTodos();

        CARModel ListarPoId(int idRefCAR);

        CARModel Adicionar(CARModel titulocar);

        CARModel Atualizar(CARModel titulocar);

        bool Apagar(int id);

    }
}