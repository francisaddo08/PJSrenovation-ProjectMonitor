using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class RGBcolor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ColorRGB",
                table: "PaintingJob",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ColorRGB",
                table: "PaintingJob");
        }
    }
}
