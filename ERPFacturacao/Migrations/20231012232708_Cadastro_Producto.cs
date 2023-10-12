using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Cadastro_Producto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_clientes_ClienteFonecedorId",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteFonecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_enderecos_clientes_ClienteFonecedorId",
                table: "enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoProductoServicoId",
                table: "productos_servicos");

            migrationBuilder.DropIndex(
                name: "IX_enderecos_ClienteFonecedorId",
                table: "enderecos");

            migrationBuilder.DropIndex(
                name: "IX_contas_bancarias_ClienteFonecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropIndex(
                name: "IX_Contacto_ClienteFonecedorId",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "ClienteFonecedorId",
                table: "enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteFonecedorId",
                table: "contas_bancarias");

            migrationBuilder.DropColumn(
                name: "ClienteFonecedorId",
                table: "Contacto");

            migrationBuilder.RenameColumn(
                name: "_ProductoServico",
                table: "productos_servicos",
                newName: "CodigoArtigo");

            migrationBuilder.RenameColumn(
                name: "TipoProductoServicoId",
                table: "productos_servicos",
                newName: "TipoArtigoId");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_TipoProductoServicoId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_TipoArtigoId");

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "productos_servicos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "enderecos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "contas_bancarias",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Contacto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_ClienteId",
                table: "enderecos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_contas_bancarias_ClienteId",
                table: "contas_bancarias",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_ClienteId",
                table: "Contacto",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_clientes_ClienteId",
                table: "Contacto",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteId",
                table: "contas_bancarias",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_enderecos_clientes_ClienteId",
                table: "enderecos",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoArtigoId",
                table: "productos_servicos",
                column: "TipoArtigoId",
                principalTable: "TipoArtigo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacto_clientes_ClienteId",
                table: "Contacto");

            migrationBuilder.DropForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteId",
                table: "contas_bancarias");

            migrationBuilder.DropForeignKey(
                name: "FK_enderecos_clientes_ClienteId",
                table: "enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoArtigoId",
                table: "productos_servicos");

            migrationBuilder.DropIndex(
                name: "IX_enderecos_ClienteId",
                table: "enderecos");

            migrationBuilder.DropIndex(
                name: "IX_contas_bancarias_ClienteId",
                table: "contas_bancarias");

            migrationBuilder.DropIndex(
                name: "IX_Contacto_ClienteId",
                table: "Contacto");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "productos_servicos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "enderecos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "contas_bancarias");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Contacto");

            migrationBuilder.RenameColumn(
                name: "TipoArtigoId",
                table: "productos_servicos",
                newName: "TipoProductoServicoId");

            migrationBuilder.RenameColumn(
                name: "CodigoArtigo",
                table: "productos_servicos",
                newName: "_ProductoServico");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_TipoArtigoId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_TipoProductoServicoId");

            migrationBuilder.AddColumn<int>(
                name: "ClienteFonecedorId",
                table: "enderecos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteFonecedorId",
                table: "contas_bancarias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClienteFonecedorId",
                table: "Contacto",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_enderecos_ClienteFonecedorId",
                table: "enderecos",
                column: "ClienteFonecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_contas_bancarias_ClienteFonecedorId",
                table: "contas_bancarias",
                column: "ClienteFonecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacto_ClienteFonecedorId",
                table: "Contacto",
                column: "ClienteFonecedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacto_clientes_ClienteFonecedorId",
                table: "Contacto",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_contas_bancarias_clientes_ClienteFonecedorId",
                table: "contas_bancarias",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_enderecos_clientes_ClienteFonecedorId",
                table: "enderecos",
                column: "ClienteFonecedorId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoProductoServicoId",
                table: "productos_servicos",
                column: "TipoProductoServicoId",
                principalTable: "TipoArtigo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
