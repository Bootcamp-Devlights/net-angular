using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterviewApp_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InterviewApp_DAL
{
    public class InterviewAppDbContext : DbContext
    {
        //DbSet
        public DbSet<Entrevista> Interviews { get; set; }
        //public DbSet<Entrevistador> Interviewers { get; set; }
        //public DbSet<Entrevistado> Interviewees { get; set; }
        public DbSet<Usuario> Users { get; set; } //Table-per-herarchy TPH
        public DbSet<Pregunta> Questions { get; set; }
        public DbSet<Respuesta> Answers { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Tecnología> Tecnologias { get; set; }

        public InterviewAppDbContext(DbContextOptions<InterviewAppDbContext> options): base(options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //      "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = InterviewAppDatabase"
        //    );
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Seed
            var questions = new Pregunta[]
            {
                new Pregunta() { Id = 1, Description = "Cual es tu nombre?" },
                new Pregunta() { Id = 2, Description = "Cual es tu edad?" }
            };

            modelBuilder.Entity<Pregunta>().HasData(questions);
        }
    }
}
