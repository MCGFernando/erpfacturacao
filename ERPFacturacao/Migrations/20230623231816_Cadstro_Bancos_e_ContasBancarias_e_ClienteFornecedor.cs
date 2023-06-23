using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Cadstro_Bancos_e_ContasBancarias_e_ClienteFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bancos_clientes_fornecedores_ClienteFonecedorId",
                table: "bancos");

            migrationBuilder.DropIndex(
                name: "IX_bancos_ClienteFonecedorId",
                table: "bancos");

            migrationBuilder.DropColumn(
                name: "Agencia",
                table: "bancos");

            migrationBuilder.DropColumn(
                name: "ClienteFonecedorId",
                table: "bancos");

            migrationBuilder.AlterColumn<string>(
                name: "Sigla",
                table: "bancos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "data_actualizacao",
                table: "bancos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_anulacao",
                table: "bancos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "data_registo",
                table: "bancos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "contas_bancarias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteFornecedorId = table.Column<int>(type: "int", nullable: false),
                    ClienteFonecedorId = table.Column<int>(type: "int", nullable: false),
                    BancoId = table.Column<int>(type: "int", nullable: false),
                    numero_conta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IBAN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Agencia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gestor_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_gestor_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_alternativo_gestor_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone_gestor_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telefone_alternativo_gestor_conta = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contas_bancarias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contas_bancarias_bancos_BancoId",
                        column: x => x.BancoId,
                        principalTable: "bancos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_contas_bancarias_clientes_fornecedores_ClienteFonecedorId",
                        column: x => x.ClienteFonecedorId,
                        principalTable: "clientes_fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contas_bancarias_BancoId",
                table: "contas_bancarias",
                column: "BancoId");

            migrationBuilder.CreateIndex(
                name: "IX_contas_bancarias_ClienteFonecedorId",
                table: "contas_bancarias",
                column: "ClienteFonecedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contas_bancarias");

            migrationBuilder.DropColumn(
                name: "data_actualizacao",
                table: "bancos");

            migrationBuilder.DropColumn(
                name: "data_anulacao",
                table: "bancos");

            migrationBuilder.DropColumn(
                name: "data_registo",
                table: "bancos");

            migrationBuilder.AlterColumn<string>(
                name: "Sigla",
                table: "bancos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Agencia",
                table: "bancos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteFonecedorId",
                table: "bancos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bancos_ClienteFonecedorId",
                table: "bancos",
                column: "ClienteFonecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_bancos_clientes_fornecedores_ClienteFonecedorId",
                table: "bancos",
                column: "ClienteFonecedorId",
                principalTable: "clientes_fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
