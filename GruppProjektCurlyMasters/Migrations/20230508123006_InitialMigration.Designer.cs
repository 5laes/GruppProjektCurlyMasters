﻿// <auto-generated />
using System;
using GruppProjektCurlyMasters.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GruppProjektCurlyMasters.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230508123006_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DbLibrary.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            Name = "Claes",
                            ProjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Age = 26,
                            Name = "Alfred",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 3,
                            Age = 24,
                            Name = "Dennis",
                            ProjectId = 2
                        },
                        new
                        {
                            Id = 4,
                            Age = 99,
                            Name = "Tomten",
                            ProjectId = 1
                        });
                });

            modelBuilder.Entity("DbLibrary.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "ColdFire"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HotIce"
                        });
                });

            modelBuilder.Entity("DbLibrary.TimeReport", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeCheckIn")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeCheckOut")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("timeReports");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 1,
                            TimeCheckIn = new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            EmployeeId = 1,
                            TimeCheckIn = new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 1,
                            TimeCheckIn = new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 2,
                            TimeCheckIn = new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 2,
                            TimeCheckIn = new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            EmployeeId = 2,
                            TimeCheckIn = new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            EmployeeId = 3,
                            TimeCheckIn = new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            EmployeeId = 3,
                            TimeCheckIn = new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            EmployeeId = 3,
                            TimeCheckIn = new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            EmployeeId = 4,
                            TimeCheckIn = new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 11,
                            EmployeeId = 4,
                            TimeCheckIn = new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 12,
                            EmployeeId = 4,
                            TimeCheckIn = new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified),
                            TimeCheckOut = new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("DbLibrary.Employee", b =>
                {
                    b.HasOne("DbLibrary.Project", "Project")
                        .WithMany("Employees")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("DbLibrary.TimeReport", b =>
                {
                    b.HasOne("DbLibrary.Employee", "Employee")
                        .WithMany("TimeReports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("DbLibrary.Employee", b =>
                {
                    b.Navigation("TimeReports");
                });

            modelBuilder.Entity("DbLibrary.Project", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
