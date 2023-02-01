﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Pregunta
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Entrevista> Entrevistas { get; set; }
        public List<Respuesta> Respuestas { get; set; }
    }
}