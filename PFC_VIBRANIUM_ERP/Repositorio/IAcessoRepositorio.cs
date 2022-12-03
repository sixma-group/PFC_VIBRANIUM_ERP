using PFC_VIBRANIUM_ERP.Models;
using System.Collections.Generic;

namespace PFC_VIBRANIUM_ERP.Repositorio
    
{
    public interface IAcessoRepositorio
    {
        List<AcessoModel> BuscarTodos();

        AcessoModel ListarPoId(int idCli);

        AcessoModel Adicionar(AcessoModel cliente);

        AcessoModel Atualizar(AcessoModel cliente);

        bool Apagar(int id);

    }
}