﻿// <auto-generated />
using System;
using InterviewApp_DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterviewApp_DAL.Migrations
{
    [DbContext(typeof(InterviewAppDbContext))]
    partial class InterviewAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntrevistaPregunta", b =>
                {
                    b.Property<int>("EntrevistasId")
                        .HasColumnType("int");

                    b.Property<int>("PreguntasId")
                        .HasColumnType("int");

                    b.HasKey("EntrevistasId", "PreguntasId");

                    b.HasIndex("PreguntasId");

                    b.ToTable("EntrevistaPregunta");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EntrevistadoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Puntaje")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("EntrevistadoId");

                    b.ToTable("Interviews");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EntrevistaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("PreguntaId")
                        .HasColumnType("int");

                    b.Property<decimal?>("Puntaje")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RespuestaElegidaId")
                        .HasColumnType("int");

                    b.Property<int>("SKillEvaluadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EntrevistaId");

                    b.HasIndex("PreguntaId");

                    b.HasIndex("RespuestaElegidaId");

                    b.HasIndex("SKillEvaluadoId");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Pregunta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Cual es tu nombre?"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Cual es tu edad?"
                        });
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Respuesta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PreguntaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PreguntaId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("PerfilId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Tecnología", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("Tecnologias");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Usuario");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevistado", b =>
                {
                    b.HasBaseType("InterviewApp_DAL.Models.Usuario");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PerfilId")
                        .HasColumnType("int");

                    b.HasIndex("PerfilId");

                    b.HasDiscriminator().HasValue("Entrevistado");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevistador", b =>
                {
                    b.HasBaseType("InterviewApp_DAL.Models.Usuario");

                    b.Property<int?>("EntrevistaId")
                        .HasColumnType("int");

                    b.HasIndex("EntrevistaId");

                    b.HasDiscriminator().HasValue("Entrevistador");
                });

            modelBuilder.Entity("EntrevistaPregunta", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Entrevista", null)
                        .WithMany()
                        .HasForeignKey("EntrevistasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterviewApp_DAL.Models.Pregunta", null)
                        .WithMany()
                        .HasForeignKey("PreguntasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevista", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Entrevistado", "Entrevistado")
                        .WithMany()
                        .HasForeignKey("EntrevistadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrevistado");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Feedback", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Entrevista", "Entrevista")
                        .WithMany("Feedbacks")
                        .HasForeignKey("EntrevistaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterviewApp_DAL.Models.Pregunta", "Pregunta")
                        .WithMany()
                        .HasForeignKey("PreguntaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterviewApp_DAL.Models.Respuesta", "RespuestaElegida")
                        .WithMany()
                        .HasForeignKey("RespuestaElegidaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterviewApp_DAL.Models.Skill", "SKillEvaluado")
                        .WithMany()
                        .HasForeignKey("SKillEvaluadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entrevista");

                    b.Navigation("Pregunta");

                    b.Navigation("RespuestaElegida");

                    b.Navigation("SKillEvaluado");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Respuesta", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Pregunta", null)
                        .WithMany("Respuestas")
                        .HasForeignKey("PreguntaId");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Skill", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Perfil", null)
                        .WithMany("Skills")
                        .HasForeignKey("PerfilId");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevistado", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Perfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevistador", b =>
                {
                    b.HasOne("InterviewApp_DAL.Models.Entrevista", null)
                        .WithMany("Entrevistadores")
                        .HasForeignKey("EntrevistaId");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Entrevista", b =>
                {
                    b.Navigation("Entrevistadores");

                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Perfil", b =>
                {
                    b.Navigation("Skills");
                });

            modelBuilder.Entity("InterviewApp_DAL.Models.Pregunta", b =>
                {
                    b.Navigation("Respuestas");
                });
#pragma warning restore 612, 618
        }
    }
}
