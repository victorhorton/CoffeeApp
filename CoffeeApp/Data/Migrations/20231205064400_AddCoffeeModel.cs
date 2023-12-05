using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoffeeApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCoffeeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brews",
                table: "Brews");

            migrationBuilder.RenameTable(
                name: "Brews",
                newName: "Brew");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brew",
                table: "Brew",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Brew",
                table: "Brew");

            migrationBuilder.RenameTable(
                name: "Brew",
                newName: "Brews");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Brews",
                table: "Brews",
                column: "Id");
        }
    }
}
