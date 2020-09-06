using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class June23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WallColourName",
                table: "PaintingJob",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WallColourName",
                table: "PaintingJob");
        }
    }
}
