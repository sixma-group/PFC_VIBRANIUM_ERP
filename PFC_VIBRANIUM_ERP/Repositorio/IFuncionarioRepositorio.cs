using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IFuncionarioRepositorio
    {
        List<FuncionarioModel> BuscarTodos();

        FuncionarioModel ListarPoId(int idFunc);

        FuncionarioModel Adicionar(FuncionarioModel funcionario);

        FuncionarioModel Atualizar(FuncionarioModel funcionario);

        bool Apagar(int id);

    }
}