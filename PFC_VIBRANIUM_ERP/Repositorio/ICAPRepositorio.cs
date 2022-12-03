using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface ICAPRepositorio
    {
        List<CAPModel> BuscarTodos();

        CAPModel ListarPoId(int idRefCAP);

        CAPModel Adicionar(CAPModel titulocap);

        CAPModel Atualizar(CAPModel titulocap);

        bool Apagar(int id);

    }
}