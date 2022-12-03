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

        public EnderecoModel Adicionar(EnderecoModel enderecoa)
        {
            //Gravar no banco de dados
            _bancoContext.Endereco.Add(enderecoa);
            _bancoContext.SaveChanges();
            return enderecoa;
        }

        public EnderecoModel Atualizar(EnderecoModel enderecoa)
        {

            EnderecoModel enderecoDB = ListarPoId(enderecoa.idEnd);


            if (enderecoDB == null) throw new Exception("Houve um erro na atualização do endereco!");

            enderecoDB.tipo = enderecoa.tipo;
            enderecoDB.descricao = enderecoa.descricao;
            enderecoDB.cep = enderecoa.cep;
            enderecoDB.endereco = enderecoa.endereco;
            enderecoDB.numero = enderecoa.numero;
            enderecoDB.bairro = enderecoa.bairro;
            enderecoDB.cidade = enderecoa.cidade;
            enderecoDB.contato = enderecoa.contato;
            enderecoDB.telefone = enderecoa.telefone;
            enderecoDB.email = enderecoa.email;



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
