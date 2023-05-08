using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GruppProjektCurlyMasters.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "timeReports",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeCheckIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeCheckOut = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_timeReports", x => x.Id);
                    table.ForeignKey(
                        name: "FK_timeReports_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "ColdFire" },
                    { 2, "HotIce" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Name", "ProjectId" },
                values: new object[,]
                {
                    { 1, 25, "Claes", 1 },
                    { 2, 26, "Alfred", 2 },
                    { 3, 24, "Dennis", 2 },
                    { 4, 99, "Tomten", 1 }
                });

            migrationBuilder.InsertData(
                table: "timeReports",
                columns: new[] { "Id", "EmployeeId", "TimeCheckIn", "TimeCheckOut" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 2, new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 3, new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 3, new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 3, new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, new DateTime(2023, 2, 1, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 4, new DateTime(2023, 2, 2, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 2, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 4, new DateTime(2023, 2, 3, 7, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 3, 16, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ProjectId",
                table: "Employees",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_timeReports_EmployeeId",
                table: "timeReports",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "timeReports");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
