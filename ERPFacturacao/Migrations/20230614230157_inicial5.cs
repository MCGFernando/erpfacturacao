using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class inicial5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moeda_paises_PaisId",
                table: "Moeda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Moeda",
                table: "Moeda");

            migrationBuilder.RenameTable(
                name: "Moeda",
                newName: "moedas");

            migrationBuilder.RenameIndex(
                name: "IX_Moeda_PaisId",
                table: "moedas",
                newName: "IX_moedas_PaisId");

            migrationBuilder.AddColumn<DateTime>(
                name: "data_actualizacao",
                table: "moedas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_anulacao",
                table: "moedas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_registo",
                table: "moedas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_moedas",
                table: "moedas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_moedas_paises_PaisId",
                table: "moedas",
                column: "PaisId",
                principalTable: "paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_moedas_paises_PaisId",
                table: "moedas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_moedas",
                table: "moedas");

            migrationBuilder.DropColumn(
                name: "data_actualizacao",
                table: "moedas");

            migrationBuilder.DropColumn(
                name: "data_anulacao",
                table: "moedas");

            migrationBuilder.DropColumn(
                name: "data_registo",
                table: "moedas");

            migrationBuilder.RenameTable(
                name: "moedas",
                newName: "Moeda");

            migrationBuilder.RenameIndex(
                name: "IX_moedas_PaisId",
                table: "Moeda",
                newName: "IX_Moeda_PaisId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Moeda",
                table: "Moeda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Moeda_paises_PaisId",
                table: "Moeda",
                column: "PaisId",
                principalTable: "paises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
