using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Heladeria2._1.Migrations
{
    /// <inheritdoc />
    public partial class onu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Heladoss",
                columns: table => new
                {
                    IdHelado = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreHelado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CantidadHelado = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrecioHelado = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Heladoss", x => x.IdHelado);
                });

            migrationBuilder.CreateTable(
                name: "Toppingss",
                columns: table => new
                {
                    IdToppings = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Topping = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CantidadToppings = table.Column<int>(type: "int", nullable: false),
                    PrecioTopping = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppingss", x => x.IdToppings);
                });

            migrationBuilder.CreateTable(
                name: "Ventass",
                columns: table => new
                {
                    idVentas = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IngresosDeVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdHelado = table.Column<int>(type: "int", nullable: false),
                    NombreHelado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    heladoIdHelado = table.Column<int>(type: "int", nullable: false),
                    IdToppings = table.Column<int>(type: "int", nullable: false),
                    Topping = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toppingsIdToppings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventass", x => x.idVentas);
                    table.ForeignKey(
                        name: "FK_Ventass_Heladoss_heladoIdHelado",
                        column: x => x.heladoIdHelado,
                        principalTable: "Heladoss",
                        principalColumn: "IdHelado",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ventass_Toppingss_toppingsIdToppings",
                        column: x => x.toppingsIdToppings,
                        principalTable: "Toppingss",
                        principalColumn: "IdToppings",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Heladoss",
                columns: new[] { "IdHelado", "CantidadHelado", "NombreHelado", "PrecioHelado" },
                values: new object[,]
                {
                    { 1, 30.8m, "Chocolate", 43.6m },
                    { 2, 42.6m, "Fresa", 39.99m },
                    { 3, 24.5m, "Vainilla", 38.50m }
                });

            migrationBuilder.InsertData(
                table: "Toppingss",
                columns: new[] { "IdToppings", "CantidadToppings", "PrecioTopping", "Topping" },
                values: new object[,]
                {
                    { 1, 36, 13.62m, "Galletas Oreo" },
                    { 2, 20, 3.9m, "Barquillos de valinilla" },
                    { 3, 25, 6.25m, "Chispitas" },
                    { 4, 14, 13.45m, "Fresitas" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_heladoIdHelado",
                table: "Ventass",
                column: "heladoIdHelado");

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_toppingsIdToppings",
                table: "Ventass",
                column: "toppingsIdToppings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ventass");

            migrationBuilder.DropTable(
                name: "Heladoss");

            migrationBuilder.DropTable(
                name: "Toppingss");
        }
    }
}
