using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ERPFacturacao.Migrations
{
    /// <inheritdoc />
    public partial class inicial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigo_pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Moeda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codigo_moeda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dominio_topo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    codigo_telefonia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "provincias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    provincia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigo_provincia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    paises_is = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_provincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_provincias_paises_paises_is",
                        column: x => x.paises_is,
                        principalTable: "paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "municipios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    municipio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    codigo_municipio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    provincia_id = table.Column<int>(type: "int", nullable: false),
                    data_registo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    data_actualizacao = table.Column<DateTime>(type: "datetime2", nullable: true),
                    data_anulacao = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_municipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_municipios_provincias_provincia_id",
                        column: x => x.provincia_id,
                        principalTable: "provincias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_municipios_provincia_id",
                table: "municipios",
                column: "provincia_id");

            migrationBuilder.CreateIndex(
                name: "IX_provincias_paises_is",
                table: "provincias",
                column: "paises_is");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "municipios");

            migrationBuilder.DropTable(
                name: "provincias");

            migrationBuilder.DropTable(
                name: "paises");
        }
    }
}
