using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontToBack.Migrations
{
    public partial class AddCreateResentWorkTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_sliders",
                table: "sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sliderBackgrounds",
                table: "sliderBackgrounds");

            migrationBuilder.RenameTable(
                name: "sliders",
                newName: "Sliders");

            migrationBuilder.RenameTable(
                name: "sliderBackgrounds",
                newName: "SliderBackgrounds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SliderBackgrounds",
                table: "SliderBackgrounds",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "RecentWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecentWorks", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecentWorks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sliders",
                table: "Sliders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SliderBackgrounds",
                table: "SliderBackgrounds");

            migrationBuilder.RenameTable(
                name: "Sliders",
                newName: "sliders");

            migrationBuilder.RenameTable(
                name: "SliderBackgrounds",
                newName: "sliderBackgrounds");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliders",
                table: "sliders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sliderBackgrounds",
                table: "sliderBackgrounds",
                column: "Id");
        }
    }
}
