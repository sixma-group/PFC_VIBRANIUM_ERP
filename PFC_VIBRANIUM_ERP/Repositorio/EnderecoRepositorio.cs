using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public EnderecoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public EnderecoModel ListarPoId(int id)
        {
            return _bancoContext.Endereco.FirstOrDefault(x => x.idEnd == id);
        }
        public List<EnderecoModel> BuscarTodos()
        {
            return _bancoContext.Endereco.ToList();
        }

        public EnderecoModel Adicionar(EnderecoModel endereco)
        {
            //Gravar no banco de dados
            _bancoContext.Endereco.Add(endereco);
            _bancoContext.SaveChanges();
            return endereco;
        }

        public EnderecoModel Atualizar(EnderecoModel endereco)
        {

            EnderecoModel enderecoDB = ListarPoId(endereco.idEnd);


            if (enderecoDB == null) throw new Exception("Houve um erro na atualização do endereco!");

            enderecoDB.tipo = endereco.tipo;
            enderecoDB.descricao = endereco.descricao;
            enderecoDB.cep = endereco.cep;
            enderecoDB.endereco = endereco.endereco;
            enderecoDB.numero = endereco.numero;
            enderecoDB.bairro = endereco.bairro;
            enderecoDB.cidade = endereco.cidade;
            enderecoDB.contato = endereco.contato;
            enderecoDB.telefone = endereco.telefone;
            enderecoDB.email = endereco.email;



            _bancoContext.Endereco.Update(enderecoDB);
            _bancoContext.SaveChanges();

            return enderecoDB;

        }

        public bool Apagar(int id)
        {
            EnderecoModel enderecoDB = ListarPoId(id);

            if (enderecoDB == null) throw new Exception("Houve um erro na excluão do registro de endereco!");
            _bancoContext.Endereco.Remove(enderecoDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
