using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Implements.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Initials = table.Column<string>(nullable: false),
                    Region = table.Column<string>(nullable: false),
                    Population = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schooles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    School_Number = table.Column<int>(nullable: false),
                    Number_Of_Students = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schooles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Schooles_Citys_CityId",
                        column: x => x.CityId,
                        principalTable: "Citys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Classeses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Curator = table.Column<string>(nullable: false),
                    Course = table.Column<int>(nullable: false),
                    Specialization = table.Column<string>(nullable: false),
                    SchoolId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classeses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Classeses_Schooles_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schooles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    District = table.Column<string>(nullable: false),
                    Foreign_Student = table.Column<bool>(nullable: false),
                    ClassesId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Students_Classeses_ClassesId",
                        column: x => x.ClassesId,
                        principalTable: "Classeses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Advancementses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Subject = table.Column<string>(nullable: false),
                    Grade = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Remark = table.Column<string>(nullable: false),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advancementses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Advancementses_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Advancementses_StudentId",
                table: "Advancementses",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Classeses_SchoolId",
                table: "Classeses",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Schooles_CityId",
                table: "Schooles",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ClassesId",
                table: "Students",
                column: "ClassesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advancementses");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Classeses");

            migrationBuilder.DropTable(
                name: "Schooles");

            migrationBuilder.DropTable(
                name: "Citys");
        }
    }
}
