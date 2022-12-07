using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase3_Ejemplo
{
    //Value Type
    public struct MyStruct
    {
        private int _edad;

        public int MyProperty { get; set; }

        public MyStruct()
        {
            _edad = 0;
            MyProperty = 0;
        }

        public void MyMethod()
        {

        }
    }
}
