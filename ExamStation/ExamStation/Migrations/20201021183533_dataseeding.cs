using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class dataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "QuestionBank",
                columns: new[] { "Id", "DifficultyLevel", "Explanation", "Hints", "Mark", "Question", "QuestionGroupId", "QuestionType", "Upload" },
                values: new object[] { 1, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer", null, "Single Answer", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "QuestionGroup",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 2, "Math" },
                    { 3, "Chemistry" },
                    { 4, "General Knowledge" },
                    { 5, "Computer Science" }
                });
        }
    }
}
