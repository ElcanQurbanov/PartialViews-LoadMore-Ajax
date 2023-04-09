using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class AddNewTableAboutUs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_aboutUs",
                table: "aboutUs");

            migrationBuilder.RenameTable(
                name: "aboutUs",
                newName: "AboutUs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AboutUs",
                table: "AboutUs",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AboutUs",
                table: "AboutUs");

            migrationBuilder.RenameTable(
                name: "AboutUs",
                newName: "aboutUs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_aboutUs",
                table: "aboutUs",
                column: "Id");
        }
    }
}
