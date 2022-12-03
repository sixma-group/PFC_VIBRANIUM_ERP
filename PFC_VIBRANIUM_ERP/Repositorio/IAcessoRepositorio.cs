using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
    
{
    public interface IAcessoRepositorio
    {
        List<AcessoModel> BuscarTodos();

        AcessoModel ListarPoId(int idUsr);

        AcessoModel Adicionar(AcessoModel acesso);

        AcessoModel Atualizar(AcessoModel acesso);

        bool Apagar(int id);

    }
}