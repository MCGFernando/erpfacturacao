using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Codigo_de_contasv4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClasseContabilId",
                table: "contas_contabeis_agregadoras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContaContabilAgregadoraId",
                table: "contas_contabeis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_contas_contabeis_agregadoras_ClasseContabilId",
                table: "contas_contabeis_agregadoras",
                column: "ClasseContabilId");

            migrationBuilder.CreateIndex(
                name: "IX_contas_contabeis_ContaContabilAgregadoraId",
                table: "contas_contabeis",
                column: "ContaContabilAgregadoraId");

            migrationBuilder.AddForeignKey(
                name: "FK_contas_contabeis_contas_contabeis_agregadoras_ContaContabilAgregadoraId",
                table: "contas_contabeis",
                column: "ContaContabilAgregadoraId",
                principalTable: "contas_contabeis_agregadoras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contas_contabeis_agregadoras_classes_contabeis_ClasseContabilId",
                table: "contas_contabeis_agregadoras",
                column: "ClasseContabilId",
                principalTable: "classes_contabeis",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_contas_contabeis_contas_contabeis_agregadoras_ContaContabilAgregadoraId",
                table: "contas_contabeis");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_contabeis_agregadoras_classes_contabeis_ClasseContabilId",
                table: "contas_contabeis_agregadoras");

            migrationBuilder.DropIndex(
                name: "IX_contas_contabeis_agregadoras_ClasseContabilId",
                table: "contas_contabeis_agregadoras");

            migrationBuilder.DropIndex(
                name: "IX_contas_contabeis_ContaContabilAgregadoraId",
                table: "contas_contabeis");

            migrationBuilder.DropColumn(
                name: "ClasseContabilId",
                table: "contas_contabeis_agregadoras");

            migrationBuilder.DropColumn(
                name: "ContaContabilAgregadoraId",
                table: "contas_contabeis");
        }
    }
}
