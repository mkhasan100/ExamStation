using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class answerOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionRecord_QuestionBank_QuestionBankId",
                table: "QuestionRecord");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionRecord",
                table: "QuestionRecord");

            migrationBuilder.RenameTable(
                name: "QuestionRecord",
                newName: "AnswersOptions");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionRecord_QuestionBankId",
                table: "AnswersOptions",
                newName: "IX_AnswersOptions_QuestionBankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnswersOptions",
                table: "AnswersOptions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswersOptions_QuestionBank_QuestionBankId",
                table: "AnswersOptions",
                column: "QuestionBankId",
                principalTable: "QuestionBank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswersOptions_QuestionBank_QuestionBankId",
                table: "AnswersOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnswersOptions",
                table: "AnswersOptions");

            migrationBuilder.RenameTable(
                name: "AnswersOptions",
                newName: "QuestionRecord");

            migrationBuilder.RenameIndex(
                name: "IX_AnswersOptions_QuestionBankId",
                table: "QuestionRecord",
                newName: "IX_QuestionRecord_QuestionBankId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionRecord",
                table: "QuestionRecord",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionRecord_QuestionBank_QuestionBankId",
                table: "QuestionRecord",
                column: "QuestionBankId",
                principalTable: "QuestionBank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
