using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class list : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "QuestionBank");

            migrationBuilder.AddColumn<int>(
                name: "QuestionTypeId",
                table: "QuestionBank",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionTypeId",
                table: "QuestionBank");

            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "QuestionBank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 1,
                column: "QuestionType",
                value: "Single Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 2,
                column: "QuestionType",
                value: "Single Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 3,
                column: "QuestionType",
                value: "Multi Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 4,
                column: "QuestionType",
                value: "Multi Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 5,
                column: "QuestionType",
                value: "Fill In The Blanks");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 6,
                column: "QuestionType",
                value: "Fill In The Blanks");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 7,
                column: "QuestionType",
                value: "Single Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 8,
                column: "QuestionType",
                value: "Single Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 9,
                column: "QuestionType",
                value: "Multi Answer");

            migrationBuilder.UpdateData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 10,
                column: "QuestionType",
                value: "Multi Answer");
        }
    }
}
