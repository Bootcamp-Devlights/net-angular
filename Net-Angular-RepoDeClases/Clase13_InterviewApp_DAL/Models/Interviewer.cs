using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase13_InterviewApp_DAL.Models
{
    public class Interviewer
    {
        public Interviewer()
        {
            Interviews = new List<Interview>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public DateTime? DateOfBirth { get; set; }
        public List<Interview> Interviews { get; set; }
    }
}