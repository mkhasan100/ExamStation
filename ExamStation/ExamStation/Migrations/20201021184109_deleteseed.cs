using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class deleteseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionGroup",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionGroup",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionGroup",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionGroup",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
