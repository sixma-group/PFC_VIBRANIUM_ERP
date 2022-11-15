using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _bancoContext;

        public ClienteRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public ClienteModel ListarPoId(int id)
        {
            return _bancoContext.cliente.FirstOrDefault(x => x.id == id);
        }
        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.cliente.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            //Gravar no banco de dados
            _bancoContext.cliente.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDB = ListarPoId(cliente.id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na atualiza;cão do cliente!");

            clienteDB.nome = cliente.nome;
            clienteDB.email = cliente.email;
            clienteDB.telefone = cliente.telefone;
            clienteDB.veiculo = cliente.veiculo;
            clienteDB.placa = cliente.placa;
            clienteDB.modelo = cliente.modelo;
            clienteDB.cor = cliente.cor;

            _bancoContext.cliente.Update(clienteDB);
            _bancoContext.SaveChanges();

            return clienteDB;

        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPoId(id);

            if (clienteDB == null) throw new System.Exception("Houve um erro na excluão do registro de cliente!");
            _bancoContext.cliente.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
