using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class CARRepositorio : ICARRepositorio
    {
        private readonly BancoContext _bancoContext;

        public CARRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public CARModel ListarPoId(int id)
        {
            return _bancoContext.CAR.FirstOrDefault(x => x.idRefCAR == id);
        }
        public List<CARModel> BuscarTodos()
        {
            return _bancoContext.CAR.ToList();
        }

        public CARModel Adicionar(CARModel titulocar)
        {
            //Gravar no banco de dados
            _bancoContext.CAR.Add(titulocar);
            _bancoContext.SaveChanges();
            return titulocar;
        }

        public CARModel Atualizar(CARModel titulocar)
        {

            CARModel titulocarDB = ListarPoId(titulocar.idRefCAR);


            if (titulocarDB == null) throw new Exception("Houve um erro na atualização do Titulo!");

            titulocarDB.dtTransacao = titulocar.dtTransacao;
            titulocarDB.especie = titulocar.especie;
            titulocarDB.serie = titulocar.serie;
            titulocarDB.titulo = titulocar.titulo;
            titulocarDB.valor = titulocar.valor;
            titulocarDB.dtVencimento = titulocar.dtVencimento;
            titulocarDB.dtEmissao = titulocar.dtEmissao;
            titulocarDB.moeda = titulocar.moeda;
            titulocarDB.parcela = titulocar.parcela;
            titulocarDB.status = titulocar.status;
            titulocarDB.idCli = titulocar.idCli;


            _bancoContext.CAR.Update(titulocarDB);
            _bancoContext.SaveChanges();

            return titulocarDB;

        }

        public bool Apagar(int id)
        {
            CARModel titulocarDB = ListarPoId(id);

            if (titulocarDB == null) throw new Exception("Houve um erro na excluão do Titulo!");
            _bancoContext.CAR.Remove(titulocarDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public List<CARModel> BuscarTodosCAR()
        {
            throw new NotImplementedException();
        }

        public CARModel ListarPoIdCAR(int idRefCAR)
        {
            throw new NotImplementedException();
        }

        public CARModel AdicionarCAR(CARModel titulocar)
        {
            throw new NotImplementedException();
        }

        public CARModel AtualizarCAR(CARModel titulocar)
        {
            throw new NotImplementedException();
        }

        public bool ApagarCAR(int id)
        {
            throw new NotImplementedException();
        }
    }
}
