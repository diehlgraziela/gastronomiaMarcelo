﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BancoDeDados.Migrations
{
    public partial class senac01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CNPJ = table.Column<string>(nullable: true),
                    Logo = table.Column<byte[]>(nullable: true),
                    NomeEmpresa = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    EnderecoNumero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    Telefone = table.Column<string>(nullable: true),
                    CustoKwh = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CPF = table.Column<string>(nullable: true),
                    Foto = table.Column<byte[]>(nullable: true),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Rua = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Bairro = table.Column<string>(nullable: true),
                    EnderecoNumero = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Celular = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clientes_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Gastos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gastos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gastos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoReceita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoReceita_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Sigla = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UnidadesMedida_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    PermissaoAcesso = table.Column<int>(nullable: false),
                    ManterLogin = table.Column<bool>(nullable: false),
                    UsuarioAtivo = table.Column<bool>(nullable: false),
                    Imagem = table.Column<byte[]>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    NomeReceita = table.Column<string>(nullable: true),
                    PerdaPorReceita = table.Column<double>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    QuantidadeProduto = table.Column<int>(nullable: false),
                    PrecoCusto = table.Column<decimal>(nullable: false),
                    ValorLuz = table.Column<decimal>(nullable: false),
                    TempoDePreparo = table.Column<string>(nullable: true),
                    PotenciaKwh = table.Column<decimal>(nullable: false),
                    PrecoVenda = table.Column<decimal>(nullable: false),
                    TipoReceitaId = table.Column<int>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    Lucro = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Receitas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Receitas_TipoReceita_TipoReceitaId",
                        column: x => x.TipoReceitaId,
                        principalTable: "TipoReceita",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    QuantidadeReceita = table.Column<int>(nullable: false),
                    FoiEntregue = table.Column<bool>(nullable: false),
                    DataParaEntrega = table.Column<DateTime>(nullable: false),
                    DataEntregaRealizada = table.Column<DateTime>(nullable: true),
                    DataCadastroPedido = table.Column<DateTime>(nullable: false),
                    UsuarioLoginId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    PrecoVenda = table.Column<decimal>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    TotalCusto = table.Column<decimal>(nullable: false),
                    TotalLucro = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pedidos_Usuarios_UsuarioLoginId",
                        column: x => x.UsuarioLoginId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GastosReceita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GastoId = table.Column<int>(nullable: false),
                    ReceitaId = table.Column<int>(nullable: false),
                    QuantidadeGasto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GastosReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GastosReceita_Gastos_GastoId",
                        column: x => x.GastoId,
                        principalTable: "Gastos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GastosReceita_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    PrecoPorQuantidade = table.Column<decimal>(nullable: false),
                    QuantidadeUnidade = table.Column<decimal>(nullable: false),
                    UnidadeMedidaId = table.Column<int>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    ReceitaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Produtos_UnidadesMedida_UnidadeMedidaId",
                        column: x => x.UnidadeMedidaId,
                        principalTable: "UnidadesMedida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PedidosConcluidos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    QuantidadePedido = table.Column<int>(nullable: false),
                    DataConcluido = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosConcluidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosConcluidos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosConcluidos_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PedidosPendentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PedidoId = table.Column<int>(nullable: false),
                    ClienteId = table.Column<int>(nullable: false),
                    DataParaEntrega = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosPendentes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosPendentes_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PedidosPendentes_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReceitasDoPedido",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReceitaId = table.Column<int>(nullable: false),
                    PedidoId = table.Column<int>(nullable: false),
                    QuantidadeReceita = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitasDoPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReceitasDoPedido_Pedidos_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "Pedidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReceitasDoPedido_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutosReceita",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReceitaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    QuantidadeProduto = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutosReceita", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProdutosReceita_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutosReceita_Receitas_ReceitaId",
                        column: x => x.ReceitaId,
                        principalTable: "Receitas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_EmpresaId",
                table: "Clientes",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Gastos_EmpresaId",
                table: "Gastos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_GastosReceita_GastoId",
                table: "GastosReceita",
                column: "GastoId");

            migrationBuilder.CreateIndex(
                name: "IX_GastosReceita_ReceitaId",
                table: "GastosReceita",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteId",
                table: "Pedidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_EmpresaId",
                table: "Pedidos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_UsuarioLoginId",
                table: "Pedidos",
                column: "UsuarioLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosConcluidos_ClienteId",
                table: "PedidosConcluidos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosConcluidos_PedidoId",
                table: "PedidosConcluidos",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPendentes_ClienteId",
                table: "PedidosPendentes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosPendentes_PedidoId",
                table: "PedidosPendentes",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EmpresaId",
                table: "Produtos",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ReceitaId",
                table: "Produtos",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_UnidadeMedidaId",
                table: "Produtos",
                column: "UnidadeMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosReceita_ProdutoId",
                table: "ProdutosReceita",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutosReceita_ReceitaId",
                table: "ProdutosReceita",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_EmpresaId",
                table: "Receitas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Receitas_TipoReceitaId",
                table: "Receitas",
                column: "TipoReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitasDoPedido_PedidoId",
                table: "ReceitasDoPedido",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_ReceitasDoPedido_ReceitaId",
                table: "ReceitasDoPedido",
                column: "ReceitaId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoReceita_EmpresaId",
                table: "TipoReceita",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UnidadesMedida_EmpresaId",
                table: "UnidadesMedida",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_EmpresaId",
                table: "Usuarios",
                column: "EmpresaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GastosReceita");

            migrationBuilder.DropTable(
                name: "PedidosConcluidos");

            migrationBuilder.DropTable(
                name: "PedidosPendentes");

            migrationBuilder.DropTable(
                name: "ProdutosReceita");

            migrationBuilder.DropTable(
                name: "ReceitasDoPedido");

            migrationBuilder.DropTable(
                name: "Gastos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Receitas");

            migrationBuilder.DropTable(
                name: "UnidadesMedida");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "TipoReceita");

            migrationBuilder.DropTable(
                name: "Empresas");
        }
    }
}
