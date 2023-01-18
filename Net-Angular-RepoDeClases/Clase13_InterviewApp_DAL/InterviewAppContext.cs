using Clase13_InterviewApp_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase13_InterviewApp_DAL
{
    public class InterviewAppContext : DbContext
    {
         
        public DbSet<Interview> Intreviews { get; set; }

        public DbSet<Interviewer> Interviewers { get; set; }

        public DbSet<Interviewee> Interviewees { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Ansewer> Ansewers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = InterviewAppDatabase"
            );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Seed
            var questions = new Question[]
            {
                new Question() { Id = 1, Description = "Cual es tu nombre?" },
                new Question() { Id = 2, Description = "Cual es tu edad?" }
            };

            modelBuilder.Entity<Question>().HasData(questions);
        }
    }
}