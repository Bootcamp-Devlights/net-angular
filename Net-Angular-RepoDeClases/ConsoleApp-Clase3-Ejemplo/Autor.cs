using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    public class Autor: Persona, IPersona
    {
        //Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PhoneTypeEnum PhoneType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetFullName()
        {
            return "Autor: " + Name + LastName;
        }

        //No es necesario definir constructores, ni siquiera el por default
        //Pero si definimos uno custom, entonces debemos colocar tb el por default
    }
}
