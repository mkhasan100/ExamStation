using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class RemoveColumnOnlineExam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionBank_OnlineExam_OnlineExamId",
                table: "QuestionBank");

            migrationBuilder.DropIndex(
                name: "IX_QuestionBank_OnlineExamId",
                table: "QuestionBank");

            migrationBuilder.DropColumn(
                name: "OnlineExamId",
                table: "QuestionBank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OnlineExamId",
                table: "QuestionBank",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuestionBank_OnlineExamId",
                table: "QuestionBank",
                column: "OnlineExamId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionBank_OnlineExam_OnlineExamId",
                table: "QuestionBank",
                column: "OnlineExamId",
                principalTable: "OnlineExam",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
