using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class inicial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clientes_fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    CodigoClienteFornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RamoActividade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desconto = table.Column<bool>(type: "bit", nullable: true),
                    ValorDesconto = table.Column<double>(type: "float", nullable: true),
                    PrazoEntrega = table.Column<int>(type: "int", nullable: true),
                    LimiteCredito = table.Column<double>(type: "float", nullable: true),
                    TipoContribuinte = table.Column<int>(type: "int", nullable: false),
                    TipoPessoa = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Fornecedor = table.Column<bool>(type: "bit", nullable: true),
                    Cliente = table.Column<bool>(type: "bit", nullable: true),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Bi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoCivil = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes_fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_fornecedores_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Moeda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Simbolo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moeda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moeda_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ramo_actividades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ramo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ramo_actividades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipos_contactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_contactos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tipos_enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "bancos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteFonecedorId = table.Column<int>(type: "int", nullable: false),
                    Sigla = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    banco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agencia = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bancos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_bancos_clientes_fornecedores_ClienteFonecedorId",
                        column: x => x.ClienteFonecedorId,
                        principalTable: "clientes_fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoContactoId = table.Column<int>(type: "int", nullable: false),
                    ClienteFonecedorId = table.Column<int>(type: "int", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telemovel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Site = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contacto_clientes_fornecedores_ClienteFonecedorId",
                        column: x => x.ClienteFonecedorId,
                        principalTable: "clientes_fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contacto_tipos_contactos_TipoContactoId",
                        column: x => x.TipoContactoId,
                        principalTable: "tipos_contactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoEnderecoId = table.Column<int>(type: "int", nullable: false),
                    MunicipioId = table.Column<int>(type: "int", nullable: true),
                    ClienteFonecedorId = table.Column<int>(type: "int", nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_enderecos_clientes_fornecedores_ClienteFonecedorId",
                        column: x => x.ClienteFonecedorId,
                        principalTable: "clientes_fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enderecos_municipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "municipios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_enderecos_tipos_enderecos_TipoEnderecoId",
                        column: x => x.TipoEnderecoId,
                        principalTable: "tipos_enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bancos_ClienteFonecedorId",
                table: "bancos",
                column: "ClienteFonecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_fornecedores_PaisId",
                table: "clientes_fornecedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_ClienteFonecedorId",
                table: "Contacto",
                column: "ClienteFonecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_TipoContactoId",
                table: "Contacto",
                column: "TipoContactoId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_ClienteFonecedorId",
                table: "enderecos",
                column: "ClienteFonecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_MunicipioId",
                table: "enderecos",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_TipoEnderecoId",
                table: "enderecos",
                column: "TipoEnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Moeda_PaisId",
                table: "Moeda",
                column: "PaisId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bancos");

            migrationBuilder.DropTable(
                name: "Contacto");

            migrationBuilder.DropTable(
                name: "enderecos");

            migrationBuilder.DropTable(
                name: "Moeda");

            migrationBuilder.DropTable(
                name: "ramo_actividades");

            migrationBuilder.DropTable(
                name: "tipos_contactos");

            migrationBuilder.DropTable(
                name: "clientes_fornecedores");

            migrationBuilder.DropTable(
                name: "tipos_enderecos");
        }
    }
}
