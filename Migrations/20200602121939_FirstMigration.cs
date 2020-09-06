using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PJSrenovationWeb.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<string>(nullable: false),
                    Title = table.Column<string>(maxLength: 10, nullable: true),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine1 = table.Column<string>(maxLength: 50, nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(maxLength: 8, nullable: false),
                    Phone = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    EntryDate = table.Column<DateTime>(nullable: false),
                    PropertyAddres = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Painter",
                columns: table => new
                {
                    PainterID = table.Column<string>(maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    DrivingLicence = table.Column<int>(nullable: false),
                    YearOfStart = table.Column<DateTime>(nullable: false),
                    CurrentLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Painter", x => x.PainterID);
                });

            migrationBuilder.CreateTable(
                name: "Property",
                columns: table => new
                {
                    PropertyID = table.Column<string>(maxLength: 10, nullable: false),
                    ClintID = table.Column<string>(nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Location = table.Column<string>(nullable: true),
                    County = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(maxLength: 8, nullable: false),
                    PropertyType = table.Column<int>(nullable: false),
                    NumberOfRooms = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Property", x => x.PropertyID);
                    table.ForeignKey(
                        name: "FK_Property_Client_ClintID",
                        column: x => x.ClintID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectID = table.Column<string>(maxLength: 8, nullable: false),
                    PropertyID = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    ProjectScope = table.Column<string>(nullable: true),
                    ProjectImage = table.Column<string>(nullable: true),
                    ImageDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectID);
                    table.ForeignKey(
                        name: "FK_Project_Property_PropertyID",
                        column: x => x.PropertyID,
                        principalTable: "Property",
                        principalColumn: "PropertyID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaintingWork",
                columns: table => new
                {
                    WorkID = table.Column<string>(maxLength: 10, nullable: false),
                    ProjectID = table.Column<string>(nullable: true),
                    PropertyArea = table.Column<string>(nullable: false),
                    Surface = table.Column<int>(nullable: false),
                    ExpectedHours = table.Column<int>(nullable: false),
                    ActualHours = table.Column<int>(nullable: true),
                    WorkImage = table.Column<string>(nullable: true),
                    ImageDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingWork", x => x.WorkID);
                    table.ForeignKey(
                        name: "FK_PaintingWork_Project_ProjectID",
                        column: x => x.ProjectID,
                        principalTable: "Project",
                        principalColumn: "ProjectID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PaintingJob",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkID = table.Column<string>(nullable: false),
                    SelfEmployedPainterID = table.Column<string>(nullable: false),
                    UnderCoatType = table.Column<int>(nullable: false),
                    UnderCoatName = table.Column<string>(maxLength: 50, nullable: true),
                    Paint = table.Column<string>(maxLength: 50, nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Finish = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    ManHours = table.Column<int>(nullable: true),
                    Stages = table.Column<int>(nullable: false),
                    JobImage = table.Column<string>(nullable: true),
                    ImageDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaintingJob", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PaintingJob_Painter_SelfEmployedPainterID",
                        column: x => x.SelfEmployedPainterID,
                        principalTable: "Painter",
                        principalColumn: "PainterID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaintingJob_PaintingWork_WorkID",
                        column: x => x.WorkID,
                        principalTable: "PaintingWork",
                        principalColumn: "WorkID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubContractWork",
                columns: table => new
                {
                    SubContractWorkID = table.Column<string>(maxLength: 15, nullable: false),
                    ProjectID = table.Column<string>(nullable: true),
                    WorkImage = table.Column<string>(nullable: true),
                    SignedOff = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    ActualEndDate = table.Column<DateTime>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Carpentry = table.Column<int>(nullable: true),
                    SubContractorID = table.Column<string>(nullable: true),
                    ElectricalWork_SubContractorID = table.Column<string>(nullable: true),
                    WorkScope = table.Column<int>(nullable: true),
                    WorkArea = table.Column<string>(nullable: true),
                    WireType = table.Column<string>(nullable: true),
                    Plastering_SubContractorID = table.Column<string>(nullable: true),
                    Plastering_WorkArea = table.Column<string>(nullable: true),
                    PlumbingWork_SubContractorID = table.Column<string>(nullable: true),
                    PlumbingArea = table.Column<int>(nullable: true),
                    Tiling_SubContractorID = table.Column<string>(nullable: true),
                    PropertyArea = table.Column<string>(nullable: true),
                    TilingArea = table.Column<int>(nullable: true),
                    ColourTheme = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    WallPaperWork_SubContractorID = table.Column<string>(nullable: true),
                    WallPaperWork_ColourTheme = table.Column<string>(nullable: true),
                    Grade = table.Column<string>(nullable: true)
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
                    SubContractorID = table.Column<string>(maxLength: 20, nullable: false),
                    SubContractWorkID = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CertificateNumber = table.Column<string>(nullable: true),
                    CompanyName = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    SkillSet = table.Column<int>(nullable: false)
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
                name: "IX_PaintingJob_SelfEmployedPainterID",
                table: "PaintingJob",
                column: "SelfEmployedPainterID");

            migrationBuilder.CreateIndex(
                name: "IX_PaintingJob_WorkID",
                table: "PaintingJob",
                column: "WorkID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PaintingWork_ProjectID",
                table: "PaintingWork",
                column: "ProjectID");

            migrationBuilder.CreateIndex(
                name: "IX_Project_PropertyID",
                table: "Project",
                column: "PropertyID",
                unique: true,
                filter: "[PropertyID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Property_ClintID",
                table: "Property",
                column: "ClintID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SubContractWork_Project_ProjectID",
                table: "SubContractWork");

            migrationBuilder.DropForeignKey(
                name: "FK_SubContractor_SubContractWork_SubContractWorkID",
                table: "SubContractor");

            migrationBuilder.DropTable(
                name: "PaintingJob");

            migrationBuilder.DropTable(
                name: "Painter");

            migrationBuilder.DropTable(
                name: "PaintingWork");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Property");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "SubContractWork");

            migrationBuilder.DropTable(
                name: "SubContractor");
        }
    }
}
