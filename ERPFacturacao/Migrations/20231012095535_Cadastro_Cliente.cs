using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Cadastro_Cliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_clientes_fornecedores_ClienteFonecedorId",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_bancarias_clientes_fornecedores_ClienteFonecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_enderecos_clientes_fornecedores_ClienteFonecedorId",
                table: "enderecos");

            migrationBuilder.DropTable(
                name: "clientes_fornecedores");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "utilizadores");

            migrationBuilder.DropColumn(
                name: "ClienteFornecedorId",
                table: "contas_bancarias");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "utilizadores",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "CodigoPostal",
                table: "enderecos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "enderecos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "contas_bancarias",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telemovel",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Site",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FornecedorId",
                table: "Contacto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Principal",
                table: "Contacto",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CategoriaArtigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Categoria = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoraPai = table.Column<int>(type: "int", nullable: false),
                    NivelIdentacao = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriaArtigo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: true),
                    Desconto = table.Column<bool>(type: "bit", nullable: true),
                    ValorDesconto = table.Column<double>(type: "float", nullable: true),
                    PrazoEntrega = table.Column<int>(type: "int", nullable: true),
                    LimiteCredito = table.Column<double>(type: "float", nullable: true),
                    TipoClienteFornecedor = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContribuinteOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    RamoActividadeId = table.Column<int>(type: "int", nullable: true),
                    TipoContribuinte = table.Column<int>(type: "int", nullable: true),
                    TipoPessoa = table.Column<int>(type: "int", nullable: true),
                    EstadoCivil = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_clientes_ramo_actividades_RamoActividadeId",
                        column: x => x.RamoActividadeId,
                        principalTable: "ramo_actividades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoFornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false),
                    Desconto = table.Column<bool>(type: "bit", nullable: true),
                    ValorDesconto = table.Column<double>(type: "float", nullable: true),
                    PrazoEntrega = table.Column<int>(type: "int", nullable: true),
                    LimiteCredito = table.Column<double>(type: "float", nullable: true),
                    TipoClienteFornecedor = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContribuinteOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    RamoActividadeId = table.Column<int>(type: "int", nullable: true),
                    TipoContribuinte = table.Column<int>(type: "int", nullable: true),
                    TipoPessoa = table.Column<int>(type: "int", nullable: true),
                    EstadoCivil = table.Column<int>(type: "int", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_fornecedores_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_fornecedores_ramo_actividades_RamoActividadeId",
                        column: x => x.RamoActividadeId,
                        principalTable: "ramo_actividades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Marca",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Marca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoArtigo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _TipoArtigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoFiscalProductoServico = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoArtigo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIVA",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IVA = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<int>(type: "int", nullable: false),
                    Taxa = table.Column<double>(type: "float", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIVA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Unidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _Unidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Unidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modelo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaId = table.Column<int>(type: "int", nullable: true),
                    _Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modelo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modelo_Marca_MarcaId",
                        column: x => x.MarcaId,
                        principalTable: "Marca",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "productos_servicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    _ProductoServico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CodigoBarras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovimentaStock = table.Column<bool>(type: "bit", nullable: false),
                    Devolucao = table.Column<bool>(type: "bit", nullable: false),
                    Garantia = table.Column<int>(type: "int", nullable: false),
                    Desconto = table.Column<double>(type: "float", nullable: false),
                    PrecoCompra = table.Column<double>(type: "float", nullable: false),
                    CustoCompra = table.Column<double>(type: "float", nullable: false),
                    PrecoVenda = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Largura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comprimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    TipoIVAId = table.Column<int>(type: "int", nullable: false),
                    TipoProductoServicoId = table.Column<int>(type: "int", nullable: false),
                    ModeloId = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productos_servicos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productos_servicos_Modelo_ModeloId",
                        column: x => x.ModeloId,
                        principalTable: "Modelo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_servicos_TipoArtigo_TipoProductoServicoId",
                        column: x => x.TipoProductoServicoId,
                        principalTable: "TipoArtigo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_servicos_TipoIVA_TipoIVAId",
                        column: x => x.TipoIVAId,
                        principalTable: "TipoIVA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_productos_servicos_fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_FornecedorId",
                table: "enderecos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_contas_bancarias_FornecedorId",
                table: "contas_bancarias",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_FornecedorId",
                table: "Contacto",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_PaisId",
                table: "clientes",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_RamoActividadeId",
                table: "clientes",
                column: "RamoActividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedores_PaisId",
                table: "fornecedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_fornecedores_RamoActividadeId",
                table: "fornecedores",
                column: "RamoActividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Modelo_MarcaId",
                table: "Modelo",
                column: "MarcaId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_servicos_FornecedorId",
                table: "productos_servicos",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_servicos_ModeloId",
                table: "productos_servicos",
                column: "ModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_servicos_TipoIVAId",
                table: "productos_servicos",
                column: "TipoIVAId");

            migrationBuilder.CreateIndex(
                name: "IX_productos_servicos_TipoProductoServicoId",
                table: "productos_servicos",
                column: "TipoProductoServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_clientes_ClienteFonecedorId",
                table: "Contacto",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_fornecedores_FornecedorId",
                table: "Contacto",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteFonecedorId",
                table: "contas_bancarias",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contas_bancarias_fornecedores_FornecedorId",
                table: "contas_bancarias",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_enderecos_clientes_ClienteFonecedorId",
                table: "enderecos",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enderecos_fornecedores_FornecedorId",
                table: "enderecos",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_clientes_ClienteFonecedorId",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_fornecedores_FornecedorId",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteFonecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_bancarias_fornecedores_FornecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_enderecos_clientes_ClienteFonecedorId",
                table: "enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_enderecos_fornecedores_FornecedorId",
                table: "enderecos");

            migrationBuilder.DropTable(
                name: "CategoriaArtigo");

            migrationBuilder.DropTable(
                name: "clientes");

            migrationBuilder.DropTable(
                name: "productos_servicos");

            migrationBuilder.DropTable(
                name: "Unidade");

            migrationBuilder.DropTable(
                name: "Modelo");

            migrationBuilder.DropTable(
                name: "TipoArtigo");

            migrationBuilder.DropTable(
                name: "TipoIVA");

            migrationBuilder.DropTable(
                name: "fornecedores");

            migrationBuilder.DropTable(
                name: "Marca");

            migrationBuilder.DropIndex(
                name: "IX_enderecos_FornecedorId",
                table: "enderecos");

            migrationBuilder.DropIndex(
                name: "IX_contas_bancarias_FornecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropIndex(
                name: "IX_Contacto_FornecedorId",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "utilizadores");

            migrationBuilder.DropColumn(
                name: "CodigoPostal",
                table: "enderecos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "enderecos");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropColumn(
                name: "FornecedorId",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "Principal",
                table: "Contacto");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "utilizadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteFornecedorId",
                table: "contas_bancarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Telemovel",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Telefone",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Site",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contacto",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "clientes_fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaisId = table.Column<int>(type: "int", nullable: true),
                    RamoActividadeId = table.Column<int>(type: "int", nullable: true),
                    Bi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cliente = table.Column<bool>(type: "bit", nullable: true),
                    CodigoClienteFornecedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContribuinteOrigem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Desconto = table.Column<bool>(type: "bit", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    EstadoCivil = table.Column<int>(type: "int", nullable: true),
                    Fornecedor = table.Column<bool>(type: "bit", nullable: true),
                    Genero = table.Column<int>(type: "int", nullable: true),
                    LimiteCredito = table.Column<double>(type: "float", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Naturalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeFiscal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obs = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrazoEntrega = table.Column<int>(type: "int", nullable: true),
                    TipoContribuinte = table.Column<int>(type: "int", nullable: false),
                    TipoPessoa = table.Column<int>(type: "int", nullable: false),
                    ValorDesconto = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes_fornecedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_clientes_fornecedores_paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_clientes_fornecedores_ramo_actividades_RamoActividadeId",
                        column: x => x.RamoActividadeId,
                        principalTable: "ramo_actividades",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_clientes_fornecedores_PaisId",
                table: "clientes_fornecedores",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_clientes_fornecedores_RamoActividadeId",
                table: "clientes_fornecedores",
                column: "RamoActividadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_clientes_fornecedores_ClienteFonecedorId",
                table: "Contacto",
                column: "ClienteFonecedorId",
                principalTable: "clientes_fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contas_bancarias_clientes_fornecedores_ClienteFonecedorId",
                table: "contas_bancarias",
                column: "ClienteFonecedorId",
                principalTable: "clientes_fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enderecos_clientes_fornecedores_ClienteFonecedorId",
                table: "enderecos",
                column: "ClienteFonecedorId",
                principalTable: "clientes_fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
