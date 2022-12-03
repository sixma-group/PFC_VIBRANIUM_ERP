using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class AcessoRepositorio : IAcessoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public AcessoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }

        public AcessoModel ListarPoId(int id)
        {
            return _bancoContext.Acesso.FirstOrDefault(x => x.idUsr == id);
        }
        public List<AcessoModel> BuscarTodos()
        {
            return _bancoContext.Acesso.ToList();
        }

        public AcessoModel Adicionar(AcessoModel acesso)
        {
            //Gravar no banco de dados
            _bancoContext.Acesso.Add(acesso);
            _bancoContext.SaveChanges();
            return acesso;
        }

        public AcessoModel Atualizar(AcessoModel acesso)
        {

            AcessoModel acessoDB = ListarPoId(acesso.idUsr);


            if (acessoDB == null) throw new Exception("Houve um erro na atualização do Acesso!");

            acessoDB.nome_user = acesso.nome_user;
            acessoDB.login = acesso.login;
            acessoDB.senha = acesso.senha;
            acessoDB.nivel = acesso.nivel;


            _bancoContext.Acesso.Update(acessoDB);
            _bancoContext.SaveChanges();

            return acessoDB;

        }

        public bool Apagar(int id)
        {
            AcessoModel acessoDB = ListarPoId(id);

            if (acessoDB == null) throw new Exception("Houve um erro na excluão do registro de Acesso!");
            _bancoContext.Acesso.Remove(acessoDB);
            _bancoContext.SaveChanges();

            return true;
        }

        List<AcessoModel> IAcessoRepositorio.BuscarTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
