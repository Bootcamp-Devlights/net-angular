using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clase13_InterviewApp_DAL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Interviewees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Intreviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IntervieweeId = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Score = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Intreviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Intreviews_Interviewees_IntervieweeId",
                        column: x => x.IntervieweeId,
                        principalTable: "Interviewees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ansewers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ansewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ansewers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "InterviewInterviewer",
                columns: table => new
                {
                    InterviewersId = table.Column<int>(type: "int", nullable: false),
                    InterviewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewInterviewer", x => new { x.InterviewersId, x.InterviewsId });
                    table.ForeignKey(
                        name: "FK_InterviewInterviewer_Interviewers_InterviewersId",
                        column: x => x.InterviewersId,
                        principalTable: "Interviewers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewInterviewer_Intreviews_InterviewsId",
                        column: x => x.InterviewsId,
                        principalTable: "Intreviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewQuestion",
                columns: table => new
                {
                    IntreviewsId = table.Column<int>(type: "int", nullable: false),
                    QuestionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewQuestion", x => new { x.IntreviewsId, x.QuestionsId });
                    table.ForeignKey(
                        name: "FK_InterviewQuestion_Intreviews_IntreviewsId",
                        column: x => x.IntreviewsId,
                        principalTable: "Intreviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewQuestion_Questions_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ansewers_QuestionId",
                table: "Ansewers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewInterviewer_InterviewsId",
                table: "InterviewInterviewer",
                column: "InterviewsId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewQuestion_QuestionsId",
                table: "InterviewQuestion",
                column: "QuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Intreviews_IntervieweeId",
                table: "Intreviews",
                column: "IntervieweeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ansewers");

            migrationBuilder.DropTable(
                name: "InterviewInterviewer");

            migrationBuilder.DropTable(
                name: "InterviewQuestion");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "Intreviews");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Interviewees");
        }
    }
}
