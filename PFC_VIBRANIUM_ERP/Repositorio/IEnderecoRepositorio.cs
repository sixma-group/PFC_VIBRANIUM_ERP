using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IEnderecoRepositorio
    {

        List<EnderecoModel> BuscarTodos();

        EnderecoModel ListarPoId(int idEnd);

        EnderecoModel Adicionar(EnderecoModel endereco);

        EnderecoModel Atualizar(EnderecoModel endereco);

        bool Apagar(int id);

    }
}