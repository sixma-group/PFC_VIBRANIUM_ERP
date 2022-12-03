using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class FornecedorRepositorio : IFornecedorRepositorio
    {
        private readonly BancoContext _bancoContext;

        public FornecedorRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public FornecedorModel ListarPoId(int id)
        {
            return _bancoContext.Fornecedor.FirstOrDefault(x => x.idForn == id);
        }
        public List<FornecedorModel> BuscarTodos()
        {
            return _bancoContext.Fornecedor.ToList();
        }

        public FornecedorModel Adicionar(FornecedorModel fornecedor)
        {
            //Gravar no banco de dados
            _bancoContext.Fornecedor.Add(fornecedor);
            _bancoContext.SaveChanges();
            return fornecedor;
        }

        public FornecedorModel Atualizar(FornecedorModel fornecedor)
        {

            FornecedorModel fornecedorDB = ListarPoId(fornecedor.idForn);


            if (fornecedorDB == null) throw new Exception("Houve um erro na atualização do Fornecedor!");

            fornecedorDB.razao = fornecedor.razao;
            fornecedorDB.pais = fornecedor.pais;
            fornecedorDB.estado = fornecedor.estado;
            fornecedorDB.pessoa = fornecedor.pessoa;
            fornecedorDB.idfederal = fornecedor.idfederal;
            fornecedorDB.nome_abrev = fornecedor.nome_abrev;
            fornecedorDB.tipo_pagamento = fornecedor.tipo_pagamento;
            fornecedorDB.banco = fornecedor.banco;
            fornecedorDB.agencia = fornecedor.agencia;
            fornecedorDB.conta = fornecedor.conta;
            fornecedorDB.idEnd = fornecedor.idEnd;


            _bancoContext.Fornecedor.Update(fornecedorDB);
            _bancoContext.SaveChanges();

            return fornecedorDB;

        }

        public bool Apagar(int id)
        {
            FornecedorModel fornecedorDB = ListarPoId(id);

            if (fornecedorDB == null) throw new Exception("Houve um erro na excluão do registro de Fornecedor!");
            _bancoContext.Fornecedor.Remove(fornecedorDB);
            _bancoContext.SaveChanges();

            return true;
        }

    }
}
