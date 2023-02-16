using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewApp_DAL.Migrations
{
    public partial class AlterTable_Users_RemovePerfilForEntrevistado : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
