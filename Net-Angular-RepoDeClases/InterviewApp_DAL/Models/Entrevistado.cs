using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewApp_DAL.Models
{
    public class Entrevistado : Usuario
    {
        public DateTime? CreationDate { get; set; }
        public Perfil? Perfil
        {
            get => default;
            set
            {
            }
        }
    }
}