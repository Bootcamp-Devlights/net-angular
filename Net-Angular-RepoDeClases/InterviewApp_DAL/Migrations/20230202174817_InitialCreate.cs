using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InterviewApp_DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interviewees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilId = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PerfilId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PreguntaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_PreguntaId",
                        column: x => x.PreguntaId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Interviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrevistadoId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Puntaje = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviews_Interviewees_EntrevistadoId",
                        column: x => x.EntrevistadoId,
                        principalTable: "Interviewees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntrevistaPregunta",
                columns: table => new
                {
                    EntrevistasId = table.Column<int>(type: "int", nullable: false),
                    PreguntasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntrevistaPregunta", x => new { x.EntrevistasId, x.PreguntasId });
                    table.ForeignKey(
                        name: "FK_EntrevistaPregunta_Interviews_EntrevistasId",
                        column: x => x.EntrevistasId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntrevistaPregunta_Questions_PreguntasId",
                        column: x => x.PreguntasId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrevistaId = table.Column<int>(type: "int", nullable: false),
                    SKillEvaluadoId = table.Column<int>(type: "int", nullable: false),
                    PreguntaId = table.Column<int>(type: "int", nullable: false),
                    RespuestaElegidaId = table.Column<int>(type: "int", nullable: false),
                    Puntaje = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Feedback_Answers_RespuestaElegidaId",
                        column: x => x.RespuestaElegidaId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_Interviews_EntrevistaId",
                        column: x => x.EntrevistaId,
                        principalTable: "Interviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_Questions_PreguntaId",
                        column: x => x.PreguntaId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_Skill_SKillEvaluadoId",
                        column: x => x.SKillEvaluadoId,
                        principalTable: "Skill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Interviewers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntrevistaId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interviewers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Interviewers_Interviews_EntrevistaId",
                        column: x => x.EntrevistaId,
                        principalTable: "Interviews",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description" },
                values: new object[] { 1, "Cual es tu nombre?" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Description" },
                values: new object[] { 2, "Cual es tu edad?" });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_PreguntaId",
                table: "Answers",
                column: "PreguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_EntrevistaPregunta_PreguntasId",
                table: "EntrevistaPregunta",
                column: "PreguntasId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_EntrevistaId",
                table: "Feedback",
                column: "EntrevistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_PreguntaId",
                table: "Feedback",
                column: "PreguntaId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_RespuestaElegidaId",
                table: "Feedback",
                column: "RespuestaElegidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_SKillEvaluadoId",
                table: "Feedback",
                column: "SKillEvaluadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewees_PerfilId",
                table: "Interviewees",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviewers_EntrevistaId",
                table: "Interviewers",
                column: "EntrevistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Interviews_EntrevistadoId",
                table: "Interviews",
                column: "EntrevistadoId");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_PerfilId",
                table: "Skill",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EntrevistaPregunta");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "Interviewers");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "Interviews");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Interviewees");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
