using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class deleteseed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "QuestionGroup",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    {1, "Science" },
                    { 2, "Math" },
                    { 3, "Chemistry" },
                    { 4, "General Knowledge" },
                    { 5, "Computer Science" }
                });

            migrationBuilder.InsertData(
                 table: "QuestionBank",
                 columns: new[] { "Id", "DifficultyLevel", "Explanation", "Hints", "Mark", "Question", "QuestionGroupId", "QuestionType", "Upload" },
                 values: new object[,]
                 {
                    { 2, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Describe it", 1, "Single Answer", null },
                    { 3, "Very Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math", 1, "Multi Answer", null },
                    { 4, "Very Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Math Describe it", 1, "Multi Answer", null },
                    { 5, "Medium", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry", 1, "Fill In The Blanks", null },
                    { 6, "Medium", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Chemistry Describe it", 1, "Fill In The Blanks", null },
                    { 7, "Hard", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge", 1, "Single Answer", null },
                    { 8, "Hard", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is General Knowledge Describe it", 1, "Single Answer", null },
                    { 9, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science", 1, "Multi Answer", null },
                    { 10, "Easy", "a programmable electronic device designed to accept data, perform prescribed mathematical and logical operations at high speed, and display the results of these operations.", "Nothing", 40.0, "What is Computer Science Describe it", 1, "Multi Answer", null }
                 });

            

           
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionBank_QuestionGroup_QuestionGroupId",
                table: "QuestionBank");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionGroup",
                table: "QuestionGroup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionBank",
                table: "QuestionBank");

            migrationBuilder.DropIndex(
                name: "IX_QuestionBank_QuestionGroupId",
                table: "QuestionBank");

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

            migrationBuilder.DeleteData(
                table: "QuestionGroup",
                keyColumn: "Id",
                keyValue: 1);

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

            migrationBuilder.DropColumn(
                name: "Id",
                table: "QuestionGroup");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "QuestionGroup");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "DifficultyLevel",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "Explanation",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "Hints",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "Mark",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "Question",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "QuestionType",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "Upload",
                table: "QuestionBank");

            migrationBuilder.AddColumn<int>(
                name: "TempId",
                table: "QuestionGroup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_QuestionGroup_TempId",
                table: "QuestionGroup",
                column: "TempId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionBank_QuestionGroup_QuestionGroupId",
                table: "QuestionBank",
                column: "QuestionGroupId",
                principalTable: "QuestionGroup",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
