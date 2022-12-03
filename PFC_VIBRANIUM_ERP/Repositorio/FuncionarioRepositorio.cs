using PFC_VIBRANIUM_ERP.Data;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public class FuncionarioRepositorio : IFuncionarioRepositorio
    {
        private readonly BancoContext _bancoContext;

        public FuncionarioRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public FuncionarioModel ListarPoId(int id)
        {
            return _bancoContext.Funcionario.FirstOrDefault(x => x.idFunc == id);
        }
        public List<FuncionarioModel> BuscarTodos()
        {
            return _bancoContext.Funcionario.ToList();
        }

        public FuncionarioModel Adicionar(FuncionarioModel funcionario)
        {
            //Gravar no banco de dados
            _bancoContext.Funcionario.Add(funcionario);
            _bancoContext.SaveChanges();
            return funcionario;
        }

        public FuncionarioModel Atualizar(FuncionarioModel funcionario)
        {

            FuncionarioModel funcionarioDB = ListarPoId(funcionario.idFunc);


            if (funcionarioDB == null) throw new Exception("Houve um erro na atualização do Funcionario!");

            funcionarioDB.nomeFuncionario = funcionario.nomeFuncionario;
            funcionarioDB.dtAdmissao = funcionario.dtAdmissao;
            funcionarioDB.dtTermino_contrato = funcionario.dtTermino_contrato;
            funcionarioDB.dtDesligamento = funcionario.dtDesligamento;
            funcionarioDB.cargo = funcionario.cargo;
            funcionarioDB.salario = funcionario.salario;
            funcionarioDB.forma_pagamento = funcionario.forma_pagamento;
            funcionarioDB.banco = funcionario.banco;
            funcionarioDB.agencia = funcionario.agencia;
            funcionarioDB.conta = funcionario.conta;
            funcionarioDB.idEnd = funcionario.idEnd;


            _bancoContext.Funcionario.Update(funcionarioDB);
            _bancoContext.SaveChanges();

            return funcionarioDB;
        }

        public bool Apagar(int id)
        {
            FuncionarioModel funcionarioDB = ListarPoId(id);

            if (funcionarioDB == null) throw new Exception("Houve um erro na excluão do registro de Funcionario!");
            _bancoContext.Funcionario.Remove(funcionarioDB);
            _bancoContext.SaveChanges();

            return true;
        }


    }
}
