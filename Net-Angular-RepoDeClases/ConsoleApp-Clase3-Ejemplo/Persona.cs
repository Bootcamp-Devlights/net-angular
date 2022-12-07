using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    public class Persona
    {
        public PhoneTypeEnum PhoneType { get; set; }
        public Address CompleteAddress { get; set; }

        public string GetCompleteAddressAsString()
        {
            return CompleteAddress.Street + " " + CompleteAddress.Number.ToString();
        }
    }
}
