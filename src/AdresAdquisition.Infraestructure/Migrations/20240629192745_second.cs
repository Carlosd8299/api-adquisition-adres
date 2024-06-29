using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdresAdquisition.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: -1868790158);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: -1777492295);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: -372265671);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 580576162);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 795551684);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 1084018740);

            migrationBuilder.InsertData(
                table: "Adquisiciones",
                columns: new[] { "Id", "Cantidad", "Documentacion", "FechaAdquisicion", "Presupuesto", "Proveedor", "TipoBien", "Unidad", "ValorTotal", "ValorUnitario" },
                values: new object[,]
                {
                    { 938634433, 5, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7292), 5000m, "Proveedor1", "Bien 5", "Unidad 5", 5000m, 1000m },
                    { 1358603456, 3, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7280), 3000m, "Proveedor1", "Bien 3", "Unidad 3", 3000m, 1000m },
                    { 1419511419, 4, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7290), 4000m, "Proveedor1", "Bien 4", "Unidad 4", 4000m, 1000m },
                    { 1540333251, 4, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7294), 6000m, "Proveedor1", "Bien 6", "Unidad 6", 4000m, 1000m },
                    { 1685246200, 1, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7231), 1000m, "Proveedor1", "Bien 1", "Unidad 1", 1000m, 1000m },
                    { 2014135236, 2, "Docu1", new DateTime(2024, 6, 29, 19, 27, 45, 366, DateTimeKind.Utc).AddTicks(7276), 2000m, "Proveedor1", "Bien 2", "Unidad 2", 2000m, 1000m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 938634433);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 1358603456);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 1419511419);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 1540333251);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 1685246200);

            migrationBuilder.DeleteData(
                table: "Adquisiciones",
                keyColumn: "Id",
                keyValue: 2014135236);

            migrationBuilder.InsertData(
                table: "Adquisiciones",
                columns: new[] { "Id", "Cantidad", "Documentacion", "FechaAdquisicion", "Presupuesto", "Proveedor", "TipoBien", "Unidad", "ValorTotal", "ValorUnitario" },
                values: new object[,]
                {
                    { -1868790158, 4, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9392), 4000m, "Proveedor1", "Bien 4", "Unidad 4", 4000m, 1000m },
                    { -1777492295, 5, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9401), 5000m, "Proveedor1", "Bien 5", "Unidad 5", 5000m, 1000m },
                    { -372265671, 4, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9404), 6000m, "Proveedor1", "Bien 6", "Unidad 6", 4000m, 1000m },
                    { 580576162, 3, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9389), 3000m, "Proveedor1", "Bien 3", "Unidad 3", 3000m, 1000m },
                    { 795551684, 2, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9386), 2000m, "Proveedor1", "Bien 2", "Unidad 2", 2000m, 1000m },
                    { 1084018740, 1, "Docu1", new DateTime(2024, 6, 29, 19, 20, 7, 609, DateTimeKind.Utc).AddTicks(9332), 1000m, "Proveedor1", "Bien 1", "Unidad 1", 1000m, 1000m }
                });
        }
    }
}
