using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pav.TpFinal.Infraestructura.Datos.Migrations
{
    /// <inheritdoc />
    public partial class DatosIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Id", "Documento", "Domicilio", "Nombre" },
                values: new object[,]
                {
                    { new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"), "87654321", "Tucumán", "María" },
                    { new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"), "12345678", "Tucumán", "Luis" }
                });

            migrationBuilder.InsertData(
                table: "Especies",
                columns: new[] { "Id", "Codigo", "Nombre", "PorcentajePesoCarne", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("23afb064-70fb-4e2f-bc73-9da9328d0efc"), 4, "Rinoceronte", 0.0, 1 },
                    { new Guid("5939c016-d55a-4b8c-9aba-5838e63e1dcd"), 1, "León", 0.69999999999999996, 0 },
                    { new Guid("e39f3776-83e1-4bd8-a008-a5a7b882b669"), 3, "Tigre", 0.5, 0 },
                    { new Guid("ef3d940f-7074-4e8e-8c92-1dd3646f1c8d"), 2, "Jirafa", 0.0, 1 }
                });

            migrationBuilder.InsertData(
                table: "Paises",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { new Guid("b82d4bc8-947f-40c6-ba6f-5b569093cfa4"), "Canadá" },
                    { new Guid("cd28016f-5f96-43f7-930e-ce7fd02a946d"), "Australia" },
                    { new Guid("d3eaa8ec-249c-42a6-b973-eeaed730d249"), "Sudáfrica" },
                    { new Guid("fa4dd464-68e9-49c4-8a9b-5e366ecf219b"), "Singapur" }
                });

            migrationBuilder.InsertData(
                table: "Sectores",
                columns: new[] { "Id", "EmpleadoId", "Latitud", "Limite", "Longitud", "Numero", "TipoAlimentacion" },
                values: new object[,]
                {
                    { new Guid("02587be7-f14f-4156-acf3-719bdda2b65b"), new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"), -26.250724000000002, 10, -65.522827000000007, 1, 1 },
                    { new Guid("372169cb-3b25-4172-bf32-5eed62bd13ae"), new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"), -26.257249999999999, 10, -65.523514000000006, 4, 0 },
                    { new Guid("4bb489c4-6051-492e-87c6-7fe43ba5203e"), new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"), -26.252358999999998, 10, -65.521511000000004, 2, 0 },
                    { new Guid("97bccd96-11c1-4776-a8a8-dbc29088df25"), new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"), -26.257249999999999, 10, -65.523514000000006, 5, 0 },
                    { new Guid("b70d9a62-447c-402b-bd52-77560c909aad"), new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"), -26.254660999999999, 10, -65.522726000000006, 3, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("23afb064-70fb-4e2f-bc73-9da9328d0efc"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("5939c016-d55a-4b8c-9aba-5838e63e1dcd"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("e39f3776-83e1-4bd8-a008-a5a7b882b669"));

            migrationBuilder.DeleteData(
                table: "Especies",
                keyColumn: "Id",
                keyValue: new Guid("ef3d940f-7074-4e8e-8c92-1dd3646f1c8d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("b82d4bc8-947f-40c6-ba6f-5b569093cfa4"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("cd28016f-5f96-43f7-930e-ce7fd02a946d"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("d3eaa8ec-249c-42a6-b973-eeaed730d249"));

            migrationBuilder.DeleteData(
                table: "Paises",
                keyColumn: "Id",
                keyValue: new Guid("fa4dd464-68e9-49c4-8a9b-5e366ecf219b"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("02587be7-f14f-4156-acf3-719bdda2b65b"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("372169cb-3b25-4172-bf32-5eed62bd13ae"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("4bb489c4-6051-492e-87c6-7fe43ba5203e"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("97bccd96-11c1-4776-a8a8-dbc29088df25"));

            migrationBuilder.DeleteData(
                table: "Sectores",
                keyColumn: "Id",
                keyValue: new Guid("b70d9a62-447c-402b-bd52-77560c909aad"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("7f28b5f6-7c3f-4b03-9af6-2ace3e2adf7f"));

            migrationBuilder.DeleteData(
                table: "Empleados",
                keyColumn: "Id",
                keyValue: new Guid("ef2c8314-0eaf-4842-8132-fcd6a3a2356c"));
        }
    }
}
