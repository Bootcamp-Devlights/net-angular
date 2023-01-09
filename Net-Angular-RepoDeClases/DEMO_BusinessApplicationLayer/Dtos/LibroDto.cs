using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_BusinessApplicationLayer.Dtos
{
    public class LibroDto
    {
        //Similar a la clase Libro, pero con menos properties. Solo las necesarias. Se usa para intercambio de datos entre capas
        public string Title { get; set; }
    }
}
