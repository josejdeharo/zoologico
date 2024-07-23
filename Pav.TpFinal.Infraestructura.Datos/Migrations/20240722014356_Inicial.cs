using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pav.TpFinal.Infraestructura.Datos.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Documento = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Domicilio = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Especies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PorcentajePesoCarne = table.Column<double>(type: "float", nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Especies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sectores",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Latitud = table.Column<double>(type: "float(10)", precision: 10, scale: 8, nullable: false),
                    Longitud = table.Column<double>(type: "float(10)", precision: 10, scale: 8, nullable: false),
                    Limite = table.Column<int>(type: "int", nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false),
                    EmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sectores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sectores_Empleados_EmpleadoId",
                        column: x => x.EmpleadoId,
                        principalTable: "Empleados",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Mamiferos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Edad = table.Column<int>(type: "int", nullable: false),
                    Peso = table.Column<double>(type: "float(6)", precision: 6, scale: 2, nullable: false),
                    TipoAlimentacion = table.Column<int>(type: "int", nullable: false),
                    EspecieId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PaisId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValorFijo = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mamiferos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mamiferos_Especies_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mamiferos_Paises_PaisId",
                        column: x => x.PaisId,
                        principalTable: "Paises",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Mamiferos_Sectores_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sectores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_EspecieId",
                table: "Mamiferos",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_PaisId",
                table: "Mamiferos",
                column: "PaisId");

            migrationBuilder.CreateIndex(
                name: "IX_Mamiferos_SectorId",
                table: "Mamiferos",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Sectores_EmpleadoId",
                table: "Sectores",
                column: "EmpleadoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mamiferos");

            migrationBuilder.DropTable(
                name: "Especies");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Sectores");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
