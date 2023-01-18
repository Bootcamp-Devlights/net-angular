using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clase13_InterviewApp_DAL.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Interview> Intreviews { get; set; }
        public List<Ansewer> Ansewers { get; set; }
    }
}