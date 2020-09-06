using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class PaintingUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActualHours",
                table: "PaintingWork");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ActualHours",
                table: "PaintingWork",
                type: "int",
                nullable: true);
        }
    }
}
