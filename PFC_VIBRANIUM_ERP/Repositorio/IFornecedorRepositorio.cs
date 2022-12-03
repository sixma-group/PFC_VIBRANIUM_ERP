using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Repositorio
{
    public interface IFornecedorRepositorio
    {
        List<FornecedorModel> BuscarTodos();

        FornecedorModel ListarPoId(int idForn);

        FornecedorModel Adicionar(FornecedorModel fornecedor);

        FornecedorModel Atualizar(FornecedorModel fornecedor);

        bool Apagar(int id);
    }
}