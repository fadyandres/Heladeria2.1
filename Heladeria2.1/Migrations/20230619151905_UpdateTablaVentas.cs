using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Heladeria2._1.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablaVentas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventass_Heladoss_heladoIdHelado",
                table: "Ventass");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventass_Toppingss_toppingsIdToppings",
                table: "Ventass");

            migrationBuilder.DropIndex(
                name: "IX_Ventass_heladoIdHelado",
                table: "Ventass");

            migrationBuilder.DropIndex(
                name: "IX_Ventass_toppingsIdToppings",
                table: "Ventass");

            migrationBuilder.DropColumn(
                name: "heladoIdHelado",
                table: "Ventass");

            migrationBuilder.DropColumn(
                name: "toppingsIdToppings",
                table: "Ventass");

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_IdHelado",
                table: "Ventass",
                column: "IdHelado");

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_IdToppings",
                table: "Ventass",
                column: "IdToppings");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventass_Heladoss_IdHelado",
                table: "Ventass",
                column: "IdHelado",
                principalTable: "Heladoss",
                principalColumn: "IdHelado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventass_Toppingss_IdToppings",
                table: "Ventass",
                column: "IdToppings",
                principalTable: "Toppingss",
                principalColumn: "IdToppings",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ventass_Heladoss_IdHelado",
                table: "Ventass");

            migrationBuilder.DropForeignKey(
                name: "FK_Ventass_Toppingss_IdToppings",
                table: "Ventass");

            migrationBuilder.DropIndex(
                name: "IX_Ventass_IdHelado",
                table: "Ventass");

            migrationBuilder.DropIndex(
                name: "IX_Ventass_IdToppings",
                table: "Ventass");

            migrationBuilder.AddColumn<int>(
                name: "heladoIdHelado",
                table: "Ventass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "toppingsIdToppings",
                table: "Ventass",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_heladoIdHelado",
                table: "Ventass",
                column: "heladoIdHelado");

            migrationBuilder.CreateIndex(
                name: "IX_Ventass_toppingsIdToppings",
                table: "Ventass",
                column: "toppingsIdToppings");

            migrationBuilder.AddForeignKey(
                name: "FK_Ventass_Heladoss_heladoIdHelado",
                table: "Ventass",
                column: "heladoIdHelado",
                principalTable: "Heladoss",
                principalColumn: "IdHelado",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ventass_Toppingss_toppingsIdToppings",
                table: "Ventass",
                column: "toppingsIdToppings",
                principalTable: "Toppingss",
                principalColumn: "IdToppings",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
