using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Feedback
    {
        public int Id { get; set; }
        public Entrevista Entrevista { get; set; }
        public Skill SKillEvaluado { get; set; }
        public Pregunta Pregunta { get; set; }
        public Respuesta RespuestaElegida { get; set; }
        public decimal? Puntaje { get; set; }
        public DateTime? Fecha { get; set; }
    }
}