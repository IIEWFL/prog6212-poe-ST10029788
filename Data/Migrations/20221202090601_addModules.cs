using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ModuleCalculatorWeb.Data.Migrations
{
    public partial class addModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    moduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moduleCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    moduleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    credits = table.Column<int>(type: "int", nullable: false),
                    hrs = table.Column<int>(type: "int", nullable: false),
                    selfStudy = table.Column<int>(type: "int", nullable: false),
                    Weeks = table.Column<int>(type: "int", nullable: false),
                    studyHrs = table.Column<int>(type: "int", nullable: false),
                    studyDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    remain  = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Module", x => x.moduleID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Module");
        }
    }
}
