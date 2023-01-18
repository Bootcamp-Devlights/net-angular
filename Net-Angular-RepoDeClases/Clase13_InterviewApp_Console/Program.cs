using Clase13_InterviewApp_DAL;
using Clase13_InterviewApp_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

//using (var context = new InterviewAppContext())
//{
//    context.Database.EnsureCreated();
//}

//InsertInterviewers();
//InsertInterviewees();
//GetInterviewees();
//InsertInterviewers();
//SkipAndTakeInterviewees();
//RetrieveAndUpdateInterviewer();
//SaveThatInterviewer(new Interviewer() { Id = 5,FirstName = "Martin", LastName = "Juanes" });
//DeleteAnInterviewer();
//InsertMultipleInterviewers();

void InsertMultipleInterviewers()
{
    using (var context = new InterviewAppContext())
    {
        var newInterviewers = new Interviewer[]{
       new Interviewer { FirstName = "Ruth", LastName = "Ozeki" },
       new Interviewer { FirstName = "Sofia", LastName = "Segovia" },
       new Interviewer { FirstName = "Ursula K.", LastName = "LeGuin" },
       new Interviewer { FirstName = "Hugh", LastName = "Howey" },
       new Interviewer { FirstName = "Isabelle", LastName = "Allende" }
    };

        context.AddRange(newInterviewers);

        context.ChangeTracker.DetectChanges();

        Console.WriteLine($"ChangeTracker: {context.ChangeTracker.DebugView.ShortView}");

        context.SaveChanges();
    }
}

void DeleteAnInterviewer()
{
    using (var context = new InterviewAppContext())
    {
        var interviewerToDelete = context.Interviewers.Find(5);
        if (interviewerToDelete != null)
        {
            context.Interviewers.Remove(interviewerToDelete);

            context.ChangeTracker.DetectChanges();

            Console.WriteLine($"ChangeTracker: {context.ChangeTracker.DebugView.ShortView}");

            context.SaveChanges();
        }
    }
}

void SaveThatInterviewer(Interviewer interviewer)
{
    using var anotherShortLivedContext = new InterviewAppContext();
    anotherShortLivedContext.Interviewers.Update(interviewer);

    anotherShortLivedContext.ChangeTracker.DetectChanges();

    Console.WriteLine($"ChangeTracker: {anotherShortLivedContext.ChangeTracker.DebugView.ShortView}");

    anotherShortLivedContext.SaveChanges();
}

void RetrieveAndUpdateInterviewer()
{
    using (var context = new InterviewAppContext())
    {
        var interviewer = context.Interviewers.FirstOrDefault(a => a.FirstName == "Martin");
        if (interviewer != null)
        {
            interviewer.LastName = "Coutinho";

            var interviewer1 = new Interviewer()
            {
                FirstName = "Carlos",
                LastName = "Tomasella",
            };

            context.Interviewers.Add(interviewer1);

            context.ChangeTracker.DetectChanges();

            Console.WriteLine($"ChangeTracker: {context.ChangeTracker.DebugView.ShortView}");

            context.SaveChanges();
        }
    }
}

void SkipAndTakeInterviewees()
{
    using (var context = new InterviewAppContext())
    {
        var groupSize = 2;
        for (int i = 0; i < 5; i++)
        {
            var interviewers = context.Interviewers.Skip(groupSize * i).Take(groupSize).ToList();
            Console.WriteLine($"Group {i}:");
            foreach (var interviewer in interviewers)
            {
                Console.WriteLine($" {interviewer.FirstName} {interviewer.LastName}");
            }
        }
    }
}


void GetInterviewees()
{
    using (var context = new InterviewAppContext())
    {
        var interviewers = context.Interviewees
            .Where(x => x.FirstName.StartsWith("J"))
            .ToList();

        var interviewersWithA = context.Interviewees
            .Where(x => x.FirstName.Contains("A"))
            .ToList();

        var interviewersJoaquin = context.Interviewees
           .Where(x => x.FirstName == "Joaquin")
           .ToList();

        var filteredEFFunctions = context.Interviewees
           .Where(x => EF.Functions.Like(x.FirstName, "J%"))
           .ToList();

        var interviewedOrderByLastname = context.Interviewees
           .OrderBy(x => x.LastName)
           .ThenBy(x => x.FirstName)
           .ToList();

        Console.WriteLine($"Interviewees");

        foreach (var interviewee in interviewedOrderByLastname)
        {
            Console.WriteLine($"Name: {interviewee.FirstName}, {interviewee.LastName}");
        }
    }
}

void InsertInterviewees()
{
    using (var context = new InterviewAppContext())
    {
        var interviewee1 = new Interviewee()
        {
            FirstName = "Marcelo",
            LastName = "Escobar",
        };
        var interviewee2 = new Interviewee()
        {
            FirstName = "Joaquin",
            LastName = "Branca",
        };
        context.Interviewees.Add(interviewee1);
        context.Interviewees.Add(interviewee2);
        context.SaveChanges();
    }
}

void InsertInterviewers()
{
    using (var context = new InterviewAppContext())
    {
        var interviewer1 = new Interviewer()
        {
            FirstName = "Sonia",
            LastName = "Lopez",
        };
        var interviewer2 = new Interviewer()
        {
            FirstName = "Ingnacio",
            LastName = "Migoya",
        };
        var interviewer3 = new Interviewer()
        {
            FirstName = "Martin",
            LastName = "Lopez",
        };
        var interviewer4 = new Interviewer()
        {
            FirstName = "Axel",
            LastName = "Ibarra",
        };
        var interviewer5 = new Interviewer()
        {
            FirstName = "Cynthia",
            LastName = "Aguirre",
        };
        context.Interviewers.Add(interviewer1);
        context.Interviewers.Add(interviewer2);
        context.Interviewers.Add(interviewer3);
        context.Interviewers.Add(interviewer4);
        context.Interviewers.Add(interviewer5);
        context.SaveChanges();
    }
}
