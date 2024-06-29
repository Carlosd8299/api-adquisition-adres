using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdresAdquisition.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 37799617);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 560044487);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 656766761);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 812051848);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 969837664);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 2040437846);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Adquisiciones",
                columns: new[] { "Id", "Cantidad", "Documentacion", "Estado", "FechaAdquisicion", "Presupuesto", "Proveedor", "TipoBien", "Unidad", "ValorTotal", "ValorUnitario" },
                values: new object[,]
                {
                    { 37799617, 2, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8566), 2000m, "Proveedor1", "Bien 2", "Unidad 2", 2000m, 1000m },
                    { 560044487, 4, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8579), 6000m, "Proveedor1", "Bien 6", "Unidad 6", 4000m, 1000m },
                    { 656766761, 4, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8572), 4000m, "Proveedor1", "Bien 4", "Unidad 4", 4000m, 1000m },
                    { 812051848, 1, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8502), 1000m, "Proveedor1", "Bien 1", "Unidad 1", 1000m, 1000m },
                    { 969837664, 5, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8574), 5000m, "Proveedor1", "Bien 5", "Unidad 5", 5000m, 1000m },
                    { 2040437846, 3, "Docu1", true, new DateTime(2024, 6, 29, 21, 44, 21, 409, DateTimeKind.Utc).AddTicks(8570), 3000m, "Proveedor1", "Bien 3", "Unidad 3", 3000m, 1000m }
                });
        }
    }
}
