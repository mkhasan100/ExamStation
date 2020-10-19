using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class questiongroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuestionBank",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DropColumn(
                name: "QuestionGroup",
                table: "QuestionBank");

            migrationBuilder.AddColumn<int>(
                name: "QuestionGroupId",
                table: "QuestionBank",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TakeExamMapper",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamId = table.Column<int>(nullable: false),
                    QuestionGroupId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TakeExamMapper", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionBank_QuestionGroupId",
                table: "QuestionBank",
                column: "QuestionGroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionBank_QuestionGroup_QuestionGroupId",
                table: "QuestionBank",
                column: "QuestionGroupId",
                principalTable: "QuestionGroup",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionBank_QuestionGroup_QuestionGroupId",
                table: "QuestionBank");

            migrationBuilder.DropTable(
                name: "TakeExamMapper");

            migrationBuilder.DropIndex(
                name: "IX_QuestionBank_QuestionGroupId",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "QuestionGroupId",
                table: "QuestionBank");

            migrationBuilder.AddColumn<string>(
                name: "QuestionGroup",
                table: "QuestionBank",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "QuestionBank",
                columns: new[] { "Id", "DifficultyLevel", "Explanation", "Hints", "Mark", "Question", "QuestionGroup", "QuestionType", "Upload" },
                values: new object[,]
                {
                    { 1, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer", "Science", "Single Answer", null },
                    { 2, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Describe it", "Science", "Single Answer", null },
                    { 3, "Very Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math", "Math", "Multi Answer", null },
                    { 4, "Very Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math Describe it", "Math", "Multi Answer", null },
                    { 5, "Medium", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry", "Chemistry", "Fill In The Blanks", null },
                    { 6, "Medium", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry Describe it", "Chemistry", "Fill In The Blanks", null },
                    { 7, "Hard", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge", "General Knowledge", "Single Answer", null },
                    { 8, "Hard", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge Describe it", "General Knowledge", "Single Answer", null },
                    { 9, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science", "Computer Science", "Multi Answer", null },
                    { 10, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science Describe it", "Computer Science", "Multi Answer", null }
                });
        }
    }
}
