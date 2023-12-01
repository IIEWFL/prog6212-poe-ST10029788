using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ModuleCalculatorWeb.Data.Migrations
{
    /// <inheritdoc />
    public partial class YourMigrationName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "remain ",
                table: "Module",
                newName: "remain");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "remain",
                table: "Module",
                newName: "remain ");
        }
    }
}
