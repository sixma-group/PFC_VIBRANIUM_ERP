using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class CAPRepositorio : ICAPRepositorio
    {
        private readonly BancoContext _bancoContext;

        public CAPRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public CAPModel ListarPoId(int id)
        {
            return _bancoContext.CAP.FirstOrDefault(x => x.idRefCAP == id);
        }
        public List<CAPModel> BuscarTodoscap()
        {
            return _bancoContext.CAP.ToList();
        }

        public CAPModel AdicionarCAP(CAPModel titulocap)
        {
            //Gravar no banco de dados
            _bancoContext.CAP.Add(titulocap);
            _bancoContext.SaveChanges();
            return titulocap;
        }

        public CAPModel AtualizarCAP(CAPModel titulocap)
        {

            CAPModel titulocapDB = ListarPoId(titulocap.idRefCAP);


            if (titulocapDB == null) throw new Exception("Houve um erro na atualização do Titulo!");

            titulocapDB.dtTransacao = titulocap.dtTransacao;
            titulocapDB.especie = titulocap.especie;
            titulocapDB.serie = titulocap.serie;
            titulocapDB.titulo = titulocap.titulo;
            titulocapDB.valor = titulocap.valor;
            titulocapDB.dtVencimento = titulocap.dtVencimento;
            titulocapDB.dtEmissao = titulocap.dtEmissao;
            titulocapDB.moeda = titulocap.moeda;
            titulocapDB.parcela = titulocap.parcela;
            titulocapDB.status = titulocap.status;
            titulocapDB.idForn = titulocap.idForn;


            _bancoContext.CAP.Update(titulocapDB);
            _bancoContext.SaveChanges();

            return titulocapDB;

        }

        public bool Apagar(int id)
        {
            CAPModel titulocapDB = ListarPoId(id);

            if (titulocapDB == null) throw new Exception("Houve um erro na excluão do Titulo!");
            _bancoContext.CAP.Remove(titulocapDB);
            _bancoContext.SaveChanges();

            return true;
        }

        public List<CAPModel> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public CAPModel Adicionar(CAPModel titulocap)
        {
            throw new NotImplementedException();
        }

        public CAPModel Atualizar(CAPModel titulocap)
        {
            throw new NotImplementedException();
        }
    }
      
}
