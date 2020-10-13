using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class Addanothercontroller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instruction",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instruction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionBank",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionGroup = table.Column<string>(nullable: false),
                    DifficultyLevel = table.Column<string>(nullable: false),
                    Question = table.Column<string>(nullable: false),
                    Explanation = table.Column<string>(nullable: true),
                    Upload = table.Column<byte[]>(nullable: true),
                    Hints = table.Column<string>(nullable: true),
                    Mark = table.Column<double>(nullable: false),
                    QuestionType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionBank", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instruction");

            migrationBuilder.DropTable(
                name: "QuestionBank");
        }
    }
}
