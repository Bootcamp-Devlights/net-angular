using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    public class Estudiante
    {
        //Propiedades
        public int Edad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        //Constructor por default
        public Estudiante()
        {

        }

        //Constructor definido por el programador (pueden ser varios, pero deben recibir diferentes parámetros y tipos)
        public Estudiante(int edad, string nombre, string apellido, int dni)
        {
            Edad = edad;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
        }

        //Métodos: recordar que debe devolver algo, y sino al menos la palabra void, que indica que no devuelve nada
        public string GetNombreCompleto()
        {
            return Nombre + " | " + Apellido; //Con return podemos devolver cualquier tipo de dato, incluso una instancia de otra clase
        }

        public void MetodoQueNoDevuelveNada(string palabra)
        {
            //Método que no devuelve nada y recibe un string
        }
    }
}
