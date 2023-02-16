using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewApp_DAL.Migrations
{
    public partial class AddTable_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviewers_Interviews_EntrevistaId",
                table: "Interviewers");

            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Interviewees_EntrevistadoId",
                table: "Interviews");

            migrationBuilder.DropTable(
                name: "Interviewees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Interviewers",
                table: "Interviewers");

            migrationBuilder.RenameTable(
                name: "Interviewers",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_Interviewers_EntrevistaId",
                table: "Users",
                newName: "IX_Users_EntrevistaId");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PerfilId",
                table: "Users",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Users_EntrevistadoId",
                table: "Interviews",
                column: "EntrevistadoId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Interviews_EntrevistaId",
                table: "Users",
                column: "EntrevistaId",
                principalTable: "Interviews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users",
                column: "PerfilId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Interviews_Users_EntrevistadoId",
                table: "Interviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Interviews_EntrevistaId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Perfil_PerfilId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_PerfilId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreationDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Interviewers");

            migrationBuilder.RenameIndex(
                name: "IX_Users_EntrevistaId",
                table: "Interviewers",
                newName: "IX_Interviewers_EntrevistaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Interviewers",
                table: "Interviewers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Interviewees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilId = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviewees_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Interviewees_PerfilId",
                table: "Interviewees",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviewers_Interviews_EntrevistaId",
                table: "Interviewers",
                column: "EntrevistaId",
                principalTable: "Interviews",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Interviews_Interviewees_EntrevistadoId",
                table: "Interviews",
                column: "EntrevistadoId",
                principalTable: "Interviewees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
