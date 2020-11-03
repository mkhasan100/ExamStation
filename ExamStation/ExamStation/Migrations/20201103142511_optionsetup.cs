using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class optionsetup : Migration
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
                name: "CorrectAnswer",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "DifficultyLevelId",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "ExamId",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option1",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option10",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option2",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option3",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option4",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option5",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option6",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option7",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option8",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option9",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "QuestionGroupId",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "QuestionName",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "SelectedAnswer",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "QuestionRecord");

            migrationBuilder.AddColumn<int>(
                name: "IsAnswer",
                table: "QuestionRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option",
                table: "QuestionRecord",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionBankId",
                table: "QuestionRecord",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionRecord_QuestionBankId",
                table: "QuestionRecord",
                column: "QuestionBankId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRecord_QuestionBank_QuestionBankId",
                table: "QuestionRecord",
                column: "QuestionBankId",
                principalTable: "QuestionBank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRecord_QuestionBank_QuestionBankId",
                table: "QuestionRecord");

            migrationBuilder.DropIndex(
                name: "IX_QuestionRecord_QuestionBankId",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "IsAnswer",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "Option",
                table: "QuestionRecord");

            migrationBuilder.DropColumn(
                name: "QuestionBankId",
                table: "QuestionRecord");

            migrationBuilder.AddColumn<string>(
                name: "CorrectAnswer",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DifficultyLevelId",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExamId",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Option1",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option10",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option2",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option3",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option4",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option5",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option6",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option7",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option8",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Option9",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionGroupId",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionName",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QuestionType",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SelectedAnswer",
                table: "QuestionRecord",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "QuestionRecord",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "QuestionBank",
                columns: new[] { "Id", "DifficultyLevelId", "Explanation", "Hints", "Mark", "Question", "QuestionGroupId", "QuestionType", "TotalOption", "Upload" },
                values: new object[,]
                {
                    { 1, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer", null, "Single Answer", null, null },
                    { 2, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Describe it", null, "Single Answer", null, null },
                    { 3, 2, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math", null, "Multi Answer", null, null },
                    { 4, 2, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math Describe it", null, "Multi Answer", null, null },
                    { 5, 3, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry", null, "Fill In The Blanks", null, null },
                    { 6, 3, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry Describe it", null, "Fill In The Blanks", null, null },
                    { 7, 4, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge", null, "Single Answer", null, null },
                    { 8, 4, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge Describe it", null, "Single Answer", null, null },
                    { 9, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science", null, "Multi Answer", null, null },
                    { 10, 1, "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science Describe it", null, "Multi Answer", null, null }
                });
        }
    }
}
