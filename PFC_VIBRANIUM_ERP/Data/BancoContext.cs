using Microsoft.EntityFrameworkCore;
using PFC_VIBRANIUM_ERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PFC_VIBRANIUM_ERP.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }
        public DbSet<ClienteModel> Cliente { get; set; }
        public DbSet<EnderecoModel> Endereco { get; set; }
        public DbSet<FornecedorModel> Fornecedor { get; set; }
        public DbSet<FuncionarioModel> Funcionario { get; set; }
        public DbSet<AcessoModel> Acesso { get; set; }
        public DbSet<CAPModel> CAP { get; set; }
        public DbSet<CARModel> CAR { get; set; }
        public DbSet<EstoqueModel> Estoque { get; set; }
        public DbSet<OPModel> OP { get; set; }
        public DbSet<PedidoModel> Pedido { get; set; }
        public DbSet<ProdutoModel> Produto { get; set; }


    }
}
