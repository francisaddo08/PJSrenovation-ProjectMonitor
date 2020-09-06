﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PJSrenovationWeb.Data;

namespace PJSrenovationWeb.Migrations
{
    [DbContext(typeof(PJSrenovationsWebContext))]
    [Migration("20200609093242_June-9")]
    partial class June9
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PJSrenovationWeb.Models.Client", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnName("FirstName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnName("LastName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<bool>("PropertyAddres")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ID");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PaintingDecoratingJob", b =>
                {
                    b.Property<int>("PaintDecoratingJobID")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("ID")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ceiling")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Door")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Finish")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ImageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ManHours")
                        .HasColumnType("int");

                    b.Property<string>("SelfEmployedPainterID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Stages")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UnderCoatName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("UnderCoatType")
                        .HasColumnType("int");

                    b.Property<string>("Wall")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WallColourValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Window")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("WorkID")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("PaintDecoratingJobID");

                    b.HasIndex("SelfEmployedPainterID");

                    b.HasIndex("WorkID")
                        .IsUnique();

                    b.ToTable("PaintingJob");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PaintingDecoratingWork", b =>
                {
                    b.Property<string>("WorkID")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExpectedHours")
                        .HasColumnType("int");

                    b.Property<DateTime?>("ImageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectID")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("PropertyArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Surface")
                        .HasColumnType("int");

                    b.Property<string>("WorkArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkID");

                    b.HasIndex("ProjectID");

                    b.ToTable("PaintingWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Project", b =>
                {
                    b.Property<string>("ProjectID")
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<DateTime?>("ActualEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ImageDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectScope")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyID")
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectID");

                    b.HasIndex("PropertyID")
                        .IsUnique()
                        .HasFilter("[PropertyID] IS NOT NULL");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Property", b =>
                {
                    b.Property<string>("PropertyID")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ClintID")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("County")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EntryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumberOfRooms")
                        .HasColumnType("int");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasColumnType("nvarchar(8)")
                        .HasMaxLength(8);

                    b.Property<int>("PropertyType")
                        .HasColumnType("int");

                    b.HasKey("PropertyID");

                    b.HasIndex("ClintID");

                    b.ToTable("Property");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.SelfEmployedPainter", b =>
                {
                    b.Property<string>("PainterID")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("CurrentLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DrivingLicence")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("YearOfStart")
                        .HasColumnType("datetime2");

                    b.HasKey("PainterID");

                    b.ToTable("Painter");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.SubContractWork", b =>
                {
                    b.Property<string>("SubContractWorkID")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<DateTime?>("ActualEndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProjectID")
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("SignedOff")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("WorkImage")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubContractWorkID");

                    b.HasIndex("ProjectID");

                    b.ToTable("SubContractWork");

                    b.HasDiscriminator<string>("Discriminator").HasValue("SubContractWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.SubContractor", b =>
                {
                    b.Property<string>("SubContractorID")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("CertificateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SkillSet")
                        .HasColumnType("int");

                    b.Property<string>("SubContractWorkID")
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubContractorID");

                    b.HasIndex("SubContractWorkID");

                    b.ToTable("SubContractor");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.CarpentryWork", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<int>("Carpentry")
                        .HasColumnType("int");

                    b.Property<string>("SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("CarpentryWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.ElectricalWork", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<string>("SubContractorID")
                        .HasColumnName("ElectricalWork_SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("WireType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkArea")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WorkScope")
                        .HasColumnType("int");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("ElectricalWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Plastering", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<string>("SubContractorID")
                        .HasColumnName("Plastering_SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("WorkArea")
                        .HasColumnName("Plastering_WorkArea")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("Plastering");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PlumbingWork", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<int>("PlumbingArea")
                        .HasColumnType("int");

                    b.Property<string>("SubContractorID")
                        .HasColumnName("PlumbingWork_SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("PlumbingWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Tiling", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<string>("ColourTheme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropertyArea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContractorID")
                        .HasColumnName("Tiling_SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TilingArea")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("Tiling");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.WallPaperWork", b =>
                {
                    b.HasBaseType("PJSrenovationWeb.Models.SubContractWork");

                    b.Property<string>("ColourTheme")
                        .HasColumnName("WallPaperWork_ColourTheme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Grade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContractorID")
                        .HasColumnName("WallPaperWork_SubContractorID")
                        .HasColumnType("nvarchar(20)");

                    b.HasIndex("SubContractorID");

                    b.HasDiscriminator().HasValue("WallPaperWork");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PaintingDecoratingJob", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SelfEmployedPainter", "Painter")
                        .WithMany()
                        .HasForeignKey("SelfEmployedPainterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PJSrenovationWeb.Models.PaintingDecoratingWork", "Work")
                        .WithOne("Job")
                        .HasForeignKey("PJSrenovationWeb.Models.PaintingDecoratingJob", "WorkID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PaintingDecoratingWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.Project", "Project")
                        .WithMany("PaintingDecoratingWorks")
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Project", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.Property", "Property")
                        .WithOne("Project")
                        .HasForeignKey("PJSrenovationWeb.Models.Project", "PropertyID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Property", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.Client", "Client")
                        .WithMany("Properties")
                        .HasForeignKey("ClintID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.SubContractWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.SubContractor", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractWork", "SubContractWork")
                        .WithMany()
                        .HasForeignKey("SubContractWorkID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.CarpentryWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.ElectricalWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Plastering", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.PlumbingWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.Tiling", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });

            modelBuilder.Entity("PJSrenovationWeb.Models.WallPaperWork", b =>
                {
                    b.HasOne("PJSrenovationWeb.Models.SubContractor", "SubContractor")
                        .WithMany()
                        .HasForeignKey("SubContractorID");
                });
#pragma warning restore 612, 618
        }
    }
}
