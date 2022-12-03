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
            return _bancoContext.Cliente.FirstOrDefault(x => x.idCli == id);
        }
        public List<ClienteModel> BuscarTodos()
        {
            return _bancoContext.Cliente.ToList();
        }

        public ClienteModel Adicionar(ClienteModel cliente)
        {
            //Gravar no banco de dados
            _bancoContext.Cliente.Add(cliente);
            _bancoContext.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            
            ClienteModel clienteDB = ListarPoId(cliente.idCli);
            

            if (clienteDB == null) throw new Exception("Houve um erro na atualização do cliente!") ;

            clienteDB.razao = cliente.razao;
            clienteDB.pais = cliente.pais;
            clienteDB.estado = cliente.estado;
            clienteDB.pessoa = cliente.pessoa;
            clienteDB.idfederal = cliente.idfederal;
            clienteDB.nome_abrev = cliente.nome_abrev;
            clienteDB.tipo_recebimento = cliente.tipo_recebimento;
            clienteDB.banco = cliente.banco;
            clienteDB.agencia = cliente.agencia;
            clienteDB.conta = cliente.conta;
            clienteDB.idEnd = cliente.idEnd;


            _bancoContext.Cliente.Update(clienteDB);
            _bancoContext.SaveChanges();

            return clienteDB;

        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDB = ListarPoId(id);

            if (clienteDB == null) throw new Exception("Houve um erro na excluão do registro de cliente!");
            _bancoContext.Cliente.Remove(clienteDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
