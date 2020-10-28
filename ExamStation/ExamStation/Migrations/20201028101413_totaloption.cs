using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamStation.Migrations
{
    public partial class totaloption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalOption",
                table: "QuestionBank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalOption",
                table: "QuestionBank",
                type: "int",
                nullable: true);
        }
    }
}
