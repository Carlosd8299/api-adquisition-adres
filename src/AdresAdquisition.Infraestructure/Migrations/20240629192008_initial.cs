using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdresAdquisition.Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adquisiciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presupuesto = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Unidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoBien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FechaAdquisicion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Proveedor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Documentacion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adquisiciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LogHistoricos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Event = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogHistoricos", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adquisiciones");

            migrationBuilder.DropTable(
                name: "LogHistoricos");
        }
    }
}
