using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Codigo_de_contas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SerieId",
                table: "tipos_documentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "classes_contabeis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Classe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_classes_contabeis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contas_contabeis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequencia = table.Column<long>(type: "bigint", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas_contabeis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "contas_contabeis_agregadoras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas_contabeis_agregadoras", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoSerie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sequencia = table.Column<long>(type: "bigint", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataInicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LimiteInferior = table.Column<long>(type: "bigint", nullable: false),
                    LimiteSuperior = table.Column<long>(type: "bigint", nullable: false),
                    UltimoDocumento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataUltimoDocumento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serie", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tipos_documentos_SerieId",
                table: "tipos_documentos",
                column: "SerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_tipos_documentos_Serie_SerieId",
                table: "tipos_documentos",
                column: "SerieId",
                principalTable: "Serie",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tipos_documentos_Serie_SerieId",
                table: "tipos_documentos");

            migrationBuilder.DropTable(
                name: "classes_contabeis");

            migrationBuilder.DropTable(
                name: "contas_contabeis");

            migrationBuilder.DropTable(
                name: "contas_contabeis_agregadoras");

            migrationBuilder.DropTable(
                name: "Serie");

            migrationBuilder.DropIndex(
                name: "IX_tipos_documentos_SerieId",
                table: "tipos_documentos");

            migrationBuilder.DropColumn(
                name: "SerieId",
                table: "tipos_documentos");
        }
    }
}
