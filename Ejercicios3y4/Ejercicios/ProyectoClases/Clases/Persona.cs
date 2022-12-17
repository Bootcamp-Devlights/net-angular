using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Persona
    {
        private DateTime _FNac;
        
        public string NombreCompleto(string Nombre, string Apellido)
        {
            return "El nombre: " + Nombre + " y apellido: " + Apellido;

        }

        public void setFechaNac(DateTime fecha)
        {
            _FNac = fecha;
        }
        public int getFechaNac()
        {
            //DateTime hoy = DateTime.Now;
            int edad = DateTime.Today.AddTicks(- _FNac.Ticks).Year - 1;
            return edad;
        }

    }
}
