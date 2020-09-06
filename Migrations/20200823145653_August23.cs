using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class August23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubContractor_SubContractWork_SubContractWorkID",
                table: "SubContractor");

            migrationBuilder.DropTable(
                name: "SubContractWork");

            migrationBuilder.DropTable(
                name: "SubContractor");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubContractWork",
                columns: table => new
                {
                    SubContractWorkID = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ActualEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjectID = table.Column<string>(type: "nvarchar(8)", nullable: true),
                    SignedOff = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carpentry = table.Column<int>(type: "int", nullable: true),
                    SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ElectricalWork_SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    WireType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkScope = table.Column<int>(type: "int", nullable: true),
                    Plastering_SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Plastering_WorkArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlumbingArea = table.Column<int>(type: "int", nullable: true),
                    PlumbingWork_SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    ColourTheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PropertyArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tiling_SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    TilingArea = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallPaperWork_ColourTheme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WallPaperWork_SubContractorID = table.Column<string>(type: "nvarchar(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractWork", x => x.SubContractWorkID);
                    table.ForeignKey(
                        name: "FK_SubContractWork_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SubContractor",
                columns: table => new
                {
                    SubContractorID = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CertificateNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillSet = table.Column<int>(type: "int", nullable: false),
                    SubContractWorkID = table.Column<string>(type: "nvarchar(15)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubContractor", x => x.SubContractorID);
                    table.ForeignKey(
                        name: "FK_SubContractor_SubContractWork_SubContractWorkID",
                        column: x => x.SubContractWorkID,
                        principalTable: "SubContractWork",
                        principalColumn: "SubContractWorkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubContractor_SubContractWorkID",
                table: "SubContractor",
                column: "SubContractWorkID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_SubContractorID",
                table: "SubContractWork",
                column: "SubContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_ElectricalWork_SubContractorID",
                table: "SubContractWork",
                column: "ElectricalWork_SubContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_Plastering_SubContractorID",
                table: "SubContractWork",
                column: "Plastering_SubContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_PlumbingWork_SubContractorID",
                table: "SubContractWork",
                column: "PlumbingWork_SubContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_ProjectID",
                table: "SubContractWork",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_Tiling_SubContractorID",
                table: "SubContractWork",
                column: "Tiling_SubContractorID");

            migrationBuilder.CreateIndex(
                name: "IX_SubContractWork_WallPaperWork_SubContractorID",
                table: "SubContractWork",
                column: "WallPaperWork_SubContractorID");

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_SubContractorID",
                table: "SubContractWork",
                column: "SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_ElectricalWork_SubContractorID",
                table: "SubContractWork",
                column: "ElectricalWork_SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_Plastering_SubContractorID",
                table: "SubContractWork",
                column: "Plastering_SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_PlumbingWork_SubContractorID",
                table: "SubContractWork",
                column: "PlumbingWork_SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_Tiling_SubContractorID",
                table: "SubContractWork",
                column: "Tiling_SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SubContractWork_SubContractor_WallPaperWork_SubContractorID",
                table: "SubContractWork",
                column: "WallPaperWork_SubContractorID",
                principalTable: "SubContractor",
                principalColumn: "SubContractorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
