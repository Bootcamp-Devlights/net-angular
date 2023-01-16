using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Entrevista
    {
        public Entrevistado Entrevistado { get; set; }
        public List<Entrevistador> Entrevistadores { get; set; }
        public DateTime? Fecha { get; set; }
        public List<Feedback> Feedbacks { get; set; }
        public decimal? Puntaje { get; set; }
        public List<Pregunta> Preguntas { get; set; }
    }
}