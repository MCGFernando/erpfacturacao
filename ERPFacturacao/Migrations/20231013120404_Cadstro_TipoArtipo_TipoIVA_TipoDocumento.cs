using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Cadstro_TipoArtipo_TipoIVA_TipoDocumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artigos_TipoIVA_TipoIVAId",
                table: "artigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoIVA",
                table: "TipoIVA");

            migrationBuilder.DropColumn(
                name: "IVA",
                table: "TipoIVA");

            migrationBuilder.RenameTable(
                name: "TipoIVA",
                newName: "tipos_ivas");

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "TipoArtigo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "tipos_ivas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "tipo_iva",
                table: "tipos_ivas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tipos_ivas",
                table: "tipos_ivas",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "tipos_documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipos_documentos", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_tipos_ivas_TipoIVAId",
                table: "artigos",
                column: "TipoIVAId",
                principalTable: "tipos_ivas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artigos_tipos_ivas_TipoIVAId",
                table: "artigos");

            migrationBuilder.DropTable(
                name: "tipos_documentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tipos_ivas",
                table: "tipos_ivas");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "TipoArtigo");

            migrationBuilder.DropColumn(
                name: "tipo_iva",
                table: "tipos_ivas");

            migrationBuilder.RenameTable(
                name: "tipos_ivas",
                newName: "TipoIVA");

            migrationBuilder.AlterColumn<int>(
                name: "Descricao",
                table: "TipoIVA",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "IVA",
                table: "TipoIVA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoIVA",
                table: "TipoIVA",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_TipoIVA_TipoIVAId",
                table: "artigos",
                column: "TipoIVAId",
                principalTable: "TipoIVA",
                principalColumn: "Id");
        }
    }
}
