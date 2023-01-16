using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase13_InterviewApp_DAL.Models
{
    public class Interview
    {
        public int Id { get; set; }
        public Interviewee Interviewee { get; set; }
        public List<Interviewer> Interviewers { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Score { get; set; }
        public List<Question> Questions { get; set; }
    }
}