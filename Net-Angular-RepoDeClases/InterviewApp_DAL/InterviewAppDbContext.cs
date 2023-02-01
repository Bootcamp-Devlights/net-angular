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
        public DbSet<Entrevistador> Interviewers { get; set; }
        public DbSet<Entrevistado> Interviewees { get; set; }
        public DbSet<Pregunta> Questions { get; set; }
        public DbSet<Respuesta> Answers { get; set; }

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
