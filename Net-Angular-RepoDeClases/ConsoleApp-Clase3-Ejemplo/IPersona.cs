using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    public interface IPersona
    {
        //Properties
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Methods
        public string GetFullName();
    }
}
