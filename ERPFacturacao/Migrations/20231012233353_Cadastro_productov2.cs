using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class Cadastro_productov2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_Modelo_ModeloId",
                table: "productos_servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoArtigoId",
                table: "productos_servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_TipoIVA_TipoIVAId",
                table: "productos_servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_productos_servicos_fornecedores_FornecedorId",
                table: "productos_servicos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_productos_servicos",
                table: "productos_servicos");

            migrationBuilder.RenameTable(
                name: "productos_servicos",
                newName: "artigos");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_TipoIVAId",
                table: "artigos",
                newName: "IX_artigos_TipoIVAId");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_TipoArtigoId",
                table: "artigos",
                newName: "IX_artigos_TipoArtigoId");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_ModeloId",
                table: "artigos",
                newName: "IX_artigos_ModeloId");

            migrationBuilder.RenameIndex(
                name: "IX_productos_servicos_FornecedorId",
                table: "artigos",
                newName: "IX_artigos_FornecedorId");

            migrationBuilder.AlterColumn<int>(
                name: "TipoIVAId",
                table: "artigos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoVenda",
                table: "artigos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "PrecoCompra",
                table: "artigos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "Peso",
                table: "artigos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "artigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "MovimentaStock",
                table: "artigos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "artigos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Largura",
                table: "artigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Garantia",
                table: "artigos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "artigos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Devolucao",
                table: "artigos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<double>(
                name: "Desconto",
                table: "artigos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<double>(
                name: "CustoCompra",
                table: "artigos",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Comprimento",
                table: "artigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CodigoBarras",
                table: "artigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Altura",
                table: "artigos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Activo",
                table: "artigos",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddPrimaryKey(
                name: "PK_artigos",
                table: "artigos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_Modelo_ModeloId",
                table: "artigos",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_TipoArtigo_TipoArtigoId",
                table: "artigos",
                column: "TipoArtigoId",
                principalTable: "TipoArtigo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_TipoIVA_TipoIVAId",
                table: "artigos",
                column: "TipoIVAId",
                principalTable: "TipoIVA",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_artigos_fornecedores_FornecedorId",
                table: "artigos",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_artigos_Modelo_ModeloId",
                table: "artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_artigos_TipoArtigo_TipoArtigoId",
                table: "artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_artigos_TipoIVA_TipoIVAId",
                table: "artigos");

            migrationBuilder.DropForeignKey(
                name: "FK_artigos_fornecedores_FornecedorId",
                table: "artigos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_artigos",
                table: "artigos");

            migrationBuilder.RenameTable(
                name: "artigos",
                newName: "productos_servicos");

            migrationBuilder.RenameIndex(
                name: "IX_artigos_TipoIVAId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_TipoIVAId");

            migrationBuilder.RenameIndex(
                name: "IX_artigos_TipoArtigoId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_TipoArtigoId");

            migrationBuilder.RenameIndex(
                name: "IX_artigos_ModeloId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_ModeloId");

            migrationBuilder.RenameIndex(
                name: "IX_artigos_FornecedorId",
                table: "productos_servicos",
                newName: "IX_productos_servicos_FornecedorId");

            migrationBuilder.AlterColumn<int>(
                name: "TipoIVAId",
                table: "productos_servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PrecoVenda",
                table: "productos_servicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "PrecoCompra",
                table: "productos_servicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Peso",
                table: "productos_servicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Observacao",
                table: "productos_servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "MovimentaStock",
                table: "productos_servicos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ModeloId",
                table: "productos_servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Largura",
                table: "productos_servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Garantia",
                table: "productos_servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FornecedorId",
                table: "productos_servicos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Devolucao",
                table: "productos_servicos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Desconto",
                table: "productos_servicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CustoCompra",
                table: "productos_servicos",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Comprimento",
                table: "productos_servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CodigoBarras",
                table: "productos_servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Altura",
                table: "productos_servicos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Activo",
                table: "productos_servicos",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_productos_servicos",
                table: "productos_servicos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_Modelo_ModeloId",
                table: "productos_servicos",
                column: "ModeloId",
                principalTable: "Modelo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_TipoArtigo_TipoArtigoId",
                table: "productos_servicos",
                column: "TipoArtigoId",
                principalTable: "TipoArtigo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_TipoIVA_TipoIVAId",
                table: "productos_servicos",
                column: "TipoIVAId",
                principalTable: "TipoIVA",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_productos_servicos_fornecedores_FornecedorId",
                table: "productos_servicos",
                column: "FornecedorId",
                principalTable: "fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
