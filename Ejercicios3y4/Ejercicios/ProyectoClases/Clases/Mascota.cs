using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Mascota
    {
        public double energia { get; set; }
        public string nombre { get; set; }
        public TipoAnimal tipo { get; set; }
        public string Tamanio { get; set; }  
        public enum TipoAnimal
        {
            perro,
            gato
        }

        public Mascota(string nombre, TipoAnimal tipo)
        {
            this.energia = 1;
            this.nombre = nombre;
            this.tipo = tipo;
            this.Tamanio = "chico";
        }
      
        public void alimentar()
        {
            double aux = this.energia + Math.Round((this.energia * 0.3), 2);
            if (aux < 100)
            {
            this.energia = aux;

            }else
            {
                this.energia = 100.00;
                Console.WriteLine("Energia al 100%");
            }

        }
        public void correr()
        {
            double aux = this.energia - Math.Round(energia * 0.1, 2);
            if (aux >= 20)
            {
                energia = aux;
            }
            else
            {
                energia = 20.00;
                Console.WriteLine("No puede correr mas su nivel esta por debajo del 20%");
            }
        }

    }
}
