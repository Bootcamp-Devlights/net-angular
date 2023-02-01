using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase13_InterviewApp_DAL.Migrations
{
    public partial class AddDateOfBirthColumnToInterviewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                table: "Interviewers",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "Interviewers");
        }
    }
}
