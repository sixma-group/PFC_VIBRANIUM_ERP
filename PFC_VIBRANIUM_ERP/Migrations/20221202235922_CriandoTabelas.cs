using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace PFCVIBRANIUMERP.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    idEnd = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    cep = table.Column<string>(type: "text", nullable: false),
                    endereco = table.Column<string>(type: "text", nullable: false),
                    numero = table.Column<string>(type: "text", nullable: false),
                    bairro = table.Column<string>(type: "text", nullable: false),
                    cidade = table.Column<string>(type: "text", nullable: false),
                    contato = table.Column<string>(type: "text", nullable: false),
                    telefone = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.idEnd);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    idItem = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    preco = table.Column<double>(type: "double precision", nullable: false),
                    marca = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    quantidade = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.idItem);
                });

            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    idCli = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razao = table.Column<string>(type: "text", nullable: false),
                    pais = table.Column<string>(type: "text", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false),
                    pessoa = table.Column<string>(type: "text", nullable: false),
                    idfederal = table.Column<string>(type: "text", nullable: false),
                    nomeabrev = table.Column<string>(name: "nome_abrev", type: "text", nullable: false),
                    tiporecebimento = table.Column<string>(name: "tipo_recebimento", type: "text", nullable: false),
                    banco = table.Column<string>(type: "text", nullable: false),
                    agencia = table.Column<string>(type: "text", nullable: false),
                    conta = table.Column<string>(type: "text", nullable: false),
                    idEnd = table.Column<int>(type: "integer", nullable: false),
                    enderecoidEnd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.idCli);
                    table.ForeignKey(
                        name: "FK_Cliente_Endereco_enderecoidEnd",
                        column: x => x.enderecoidEnd,
                        principalTable: "Endereco",
                        principalColumn: "idEnd");
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    idForn = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    razao = table.Column<string>(type: "text", nullable: false),
                    pais = table.Column<string>(type: "text", nullable: false),
                    estado = table.Column<string>(type: "text", nullable: false),
                    pessoa = table.Column<string>(type: "text", nullable: false),
                    idfederal = table.Column<string>(type: "text", nullable: false),
                    nomeabrev = table.Column<string>(name: "nome_abrev", type: "text", nullable: false),
                    tipopagamento = table.Column<string>(name: "tipo_pagamento", type: "text", nullable: false),
                    banco = table.Column<string>(type: "text", nullable: false),
                    agencia = table.Column<string>(type: "text", nullable: false),
                    conta = table.Column<string>(type: "text", nullable: false),
                    idEnd = table.Column<int>(type: "integer", nullable: false),
                    enderecoidEnd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.idForn);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Endereco_enderecoidEnd",
                        column: x => x.enderecoidEnd,
                        principalTable: "Endereco",
                        principalColumn: "idEnd");
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    idFunc = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeFuncionario = table.Column<string>(type: "text", nullable: false),
                    dtAdmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dtTerminocontrato = table.Column<DateTime>(name: "dtTermino_contrato", type: "timestamp with time zone", nullable: false),
                    dtDesligamento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    cargo = table.Column<string>(type: "text", nullable: false),
                    salario = table.Column<double>(type: "double precision", nullable: false),
                    formapagamento = table.Column<string>(name: "forma_pagamento", type: "text", nullable: false),
                    banco = table.Column<string>(type: "text", nullable: false),
                    agencia = table.Column<string>(type: "text", nullable: false),
                    conta = table.Column<string>(type: "text", nullable: false),
                    idEnd = table.Column<int>(type: "integer", nullable: false),
                    enderecoidEnd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.idFunc);
                    table.ForeignKey(
                        name: "FK_Funcionario_Endereco_enderecoidEnd",
                        column: x => x.enderecoidEnd,
                        principalTable: "Endereco",
                        principalColumn: "idEnd");
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    idProd = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: false),
                    valoraquisicao = table.Column<double>(name: "valor_aquisicao", type: "double precision", nullable: false),
                    precosaida = table.Column<double>(name: "preco_saida", type: "double precision", nullable: false),
                    itens = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    idItem = table.Column<int>(type: "integer", nullable: false),
                    itemidItem = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.idProd);
                    table.ForeignKey(
                        name: "FK_Produto_Estoque_itemidItem",
                        column: x => x.itemidItem,
                        principalTable: "Estoque",
                        principalColumn: "idItem");
                });

            migrationBuilder.CreateTable(
                name: "CAR",
                columns: table => new
                {
                    idRefCAR = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dtTransacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    especie = table.Column<string>(type: "text", nullable: false),
                    serie = table.Column<string>(type: "text", nullable: false),
                    titulo = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    dtVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dtEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    moeda = table.Column<string>(type: "text", nullable: false),
                    parcela = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    idCli = table.Column<int>(type: "integer", nullable: false),
                    clienteidCli = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAR", x => x.idRefCAR);
                    table.ForeignKey(
                        name: "FK_CAR_Cliente_clienteidCli",
                        column: x => x.clienteidCli,
                        principalTable: "Cliente",
                        principalColumn: "idCli");
                });

            migrationBuilder.CreateTable(
                name: "CAP",
                columns: table => new
                {
                    idRefCAP = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    dtTransacao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    especie = table.Column<string>(type: "text", nullable: false),
                    serie = table.Column<string>(type: "text", nullable: false),
                    titulo = table.Column<string>(type: "text", nullable: false),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    dtVencimento = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dtEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    moeda = table.Column<string>(type: "text", nullable: false),
                    parcela = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    idForn = table.Column<int>(type: "integer", nullable: false),
                    fornecedoridForn = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CAP", x => x.idRefCAP);
                    table.ForeignKey(
                        name: "FK_CAP_Fornecedor_fornecedoridForn",
                        column: x => x.fornecedoridForn,
                        principalTable: "Fornecedor",
                        principalColumn: "idForn");
                });

            migrationBuilder.CreateTable(
                name: "Pedido",
                columns: table => new
                {
                    idPed = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    tipo = table.Column<string>(type: "text", nullable: false),
                    produtos = table.Column<string>(type: "text", nullable: false),
                    dtPedido = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    quantidade = table.Column<int>(type: "integer", nullable: false),
                    valor = table.Column<double>(type: "double precision", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    idCli = table.Column<int>(type: "integer", nullable: false),
                    clienteidCli = table.Column<int>(type: "integer", nullable: true),
                    idForn = table.Column<int>(type: "integer", nullable: true),
                    fornecedoridForn = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedido", x => x.idPed);
                    table.ForeignKey(
                        name: "FK_Pedido_Cliente_clienteidCli",
                        column: x => x.clienteidCli,
                        principalTable: "Cliente",
                        principalColumn: "idCli");
                    table.ForeignKey(
                        name: "FK_Pedido_Fornecedor_fornecedoridForn",
                        column: x => x.fornecedoridForn,
                        principalTable: "Fornecedor",
                        principalColumn: "idForn");
                });

            migrationBuilder.CreateTable(
                name: "Acesso",
                columns: table => new
                {
                    idUsr = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomeuser = table.Column<string>(name: "nome_user", type: "text", nullable: false),
                    login = table.Column<string>(type: "text", nullable: false),
                    senha = table.Column<string>(type: "text", nullable: false),
                    nivel = table.Column<string>(type: "text", nullable: false),
                    idFunc = table.Column<int>(type: "integer", nullable: false),
                    funcionarioidFunc = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acesso", x => x.idUsr);
                    table.ForeignKey(
                        name: "FK_Acesso_Funcionario_funcionarioidFunc",
                        column: x => x.funcionarioidFunc,
                        principalTable: "Funcionario",
                        principalColumn: "idFunc");
                });

            migrationBuilder.CreateTable(
                name: "OP",
                columns: table => new
                {
                    idOp = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    quantidade = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<string>(type: "text", nullable: false),
                    descricao = table.Column<string>(type: "text", nullable: false),
                    roteiro = table.Column<string>(type: "text", nullable: false),
                    dtEmissao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    dtTermino = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    idProd = table.Column<int>(type: "integer", nullable: false),
                    produtoidProd = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OP", x => x.idOp);
                    table.ForeignKey(
                        name: "FK_OP_Produto_produtoidProd",
                        column: x => x.produtoidProd,
                        principalTable: "Produto",
                        principalColumn: "idProd");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acesso_funcionarioidFunc",
                table: "Acesso",
                column: "funcionarioidFunc");

            migrationBuilder.CreateIndex(
                name: "IX_CAP_fornecedoridForn",
                table: "CAP",
                column: "fornecedoridForn");

            migrationBuilder.CreateIndex(
                name: "IX_CAR_clienteidCli",
                table: "CAR",
                column: "clienteidCli");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_enderecoidEnd",
                table: "Cliente",
                column: "enderecoidEnd");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_enderecoidEnd",
                table: "Fornecedor",
                column: "enderecoidEnd");

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_enderecoidEnd",
                table: "Funcionario",
                column: "enderecoidEnd");

            migrationBuilder.CreateIndex(
                name: "IX_OP_produtoidProd",
                table: "OP",
                column: "produtoidProd");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_clienteidCli",
                table: "Pedido",
                column: "clienteidCli");

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_fornecedoridForn",
                table: "Pedido",
                column: "fornecedoridForn");

            migrationBuilder.CreateIndex(
                name: "IX_Produto_itemidItem",
                table: "Produto",
                column: "itemidItem");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acesso");

            migrationBuilder.DropTable(
                name: "CAP");

            migrationBuilder.DropTable(
                name: "CAR");

            migrationBuilder.DropTable(
                name: "OP");

            migrationBuilder.DropTable(
                name: "Pedido");

            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
