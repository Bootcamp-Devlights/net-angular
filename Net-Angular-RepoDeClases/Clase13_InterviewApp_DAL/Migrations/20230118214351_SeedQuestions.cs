using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase13_InterviewApp_DAL.Migrations
{
    public partial class SeedQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Cual es tu nombre?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Cual es tu edad?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Questions");
        }
    }
}
