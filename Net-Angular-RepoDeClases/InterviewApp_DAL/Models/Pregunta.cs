using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Pregunta
    {
        public List<Entrevista> Entrevistas { get; set; }
        public List<Respuesta> Respuestas { get; set; }
    }
}