using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IClienteRepositorio
    {

        //Cliente
        List<ClienteModel> BuscarTodos();

        ClienteModel ListarPoId(int idCli);

        ClienteModel Adicionar(ClienteModel cliente);

        ClienteModel Atualizar(ClienteModel cliente);

        bool Apagar(int id);
    }
}
