using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class tipo_contacto_endereco : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "tipos_enderecos");

            migrationBuilder.DropColumn(
                name: "Tipo",
                table: "tipos_contactos");

            migrationBuilder.DropColumn(
                name: "RamoActividade",
                table: "clientes_fornecedores");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "moedas",
                newName: "_Moeda");

            migrationBuilder.AddColumn<string>(
                name: "tipo_endereco",
                table: "tipos_enderecos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "tipo_contacto",
                table: "tipos_contactos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ContribuinteOrigem",
                table: "clientes_fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RamoActividadeId",
                table: "clientes_fornecedores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_fornecedores_RamoActividadeId",
                table: "clientes_fornecedores",
                column: "RamoActividadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_fornecedores_ramo_actividades_RamoActividadeId",
                table: "clientes_fornecedores",
                column: "RamoActividadeId",
                principalTable: "ramo_actividades",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_fornecedores_ramo_actividades_RamoActividadeId",
                table: "clientes_fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_clientes_fornecedores_RamoActividadeId",
                table: "clientes_fornecedores");

            migrationBuilder.DropColumn(
                name: "tipo_endereco",
                table: "tipos_enderecos");

            migrationBuilder.DropColumn(
                name: "tipo_contacto",
                table: "tipos_contactos");

            migrationBuilder.DropColumn(
                name: "ContribuinteOrigem",
                table: "clientes_fornecedores");

            migrationBuilder.DropColumn(
                name: "RamoActividadeId",
                table: "clientes_fornecedores");

            migrationBuilder.RenameColumn(
                name: "_Moeda",
                table: "moedas",
                newName: "Nome");

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "tipos_enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tipo",
                table: "tipos_contactos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RamoActividade",
                table: "clientes_fornecedores",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
