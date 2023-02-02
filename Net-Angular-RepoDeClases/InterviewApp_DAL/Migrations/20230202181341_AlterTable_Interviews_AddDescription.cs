using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewApp_DAL.Migrations
{
    public partial class AlterTable_Interviews_AddDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "Interviews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "Interviews");
        }
    }
}
