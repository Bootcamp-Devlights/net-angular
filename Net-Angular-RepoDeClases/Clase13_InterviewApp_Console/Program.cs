using Clase13_InterviewApp_DAL;
using Clase13_InterviewApp_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml;

using (var context = new InterviewAppContext())
{
    context.Database.EnsureCreated();

    //context.Database.Migrate();
}

//InsertInterviewers();
//InsertInterviewees();
GetInterviewees();

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
            FirstName = "Juan",
            LastName = "Perez",
        };
        var interviewer2 = new Interviewer()
        {
            FirstName = "Pedro",
            LastName = "Gomez",
        };
        context.Interviewers.Add(interviewer1);
        context.Interviewers.Add(interviewer2);
        context.SaveChanges();
    }
}
