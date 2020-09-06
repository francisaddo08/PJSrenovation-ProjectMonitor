using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class PaintingUpdate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "ColorRGB",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "Paint",
                table: "PaintingJob");

            migrationBuilder.AlterColumn<int>(
                name: "UnderCoatType",
                table: "PaintingJob",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "PaintingJob",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ceiling",
                table: "PaintingJob",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Door",
                table: "PaintingJob",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Wall",
                table: "PaintingJob",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WallColourValue",
                table: "PaintingJob",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Window",
                table: "PaintingJob",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ceiling",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "Door",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "Wall",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "WallColourValue",
                table: "PaintingJob");

            migrationBuilder.DropColumn(
                name: "Window",
                table: "PaintingJob");

            migrationBuilder.AlterColumn<int>(
                name: "UnderCoatType",
                table: "PaintingJob",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Brand",
                table: "PaintingJob",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "PaintingJob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ColorRGB",
                table: "PaintingJob",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Paint",
                table: "PaintingJob",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }
    }
}
