using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        private DateTime _FNac;
        private Smartphone celular ;
        public Boolean RegazoUsado { get; set; }
        

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, DateTime fNac, Smartphone celular)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this._FNac = fNac;
            this.celular = celular;
        }

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
        public void setCelular(string marca, string modelo)
        {
            this.celular.marca = marca;
            this.celular.modelo = modelo;
        }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre completo: {Nombre} {Apellido}, Fecha de Nacimiento: {this._FNac} " +
                $"Celular Modelo: {this.celular.modelo}");
        }
    }
}
