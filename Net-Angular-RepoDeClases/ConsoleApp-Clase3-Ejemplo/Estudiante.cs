using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    public class Estudiante: Persona, IPersona, IUser
    {
        //Field o Campo
        private int _edad;

        //Propiedades
        public int Edad { get; set; } //Fecha de Nacimiento
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; }

        public MyEnum Enum { get; set; }


        private DateTime _dob; //Campo

        public DateTime DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        
        //2022-12-07
        //07/12/2022 //12/07/2022

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

        public int GetEdad()
        {
            return _edad;
        }

        public void SetEdad(int value)
        {
            _edad = value;
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

        public string GetDateOfBirth()
        {
            return _dob.ToShortDateString();
        }

        public string GetFullName()
        {
            return "Estudiante: " + Name + LastName;
        }
    }
}
