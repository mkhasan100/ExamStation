using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class questionbank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionGroupId",
                table: "TakeExamMapper");

            migrationBuilder.AddColumn<int>(
                name: "QuestionBankId",
                table: "TakeExamMapper",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionBankId",
                table: "TakeExamMapper");

            migrationBuilder.AddColumn<int>(
                name: "QuestionGroupId",
                table: "TakeExamMapper",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
