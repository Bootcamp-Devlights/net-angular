using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DEMO_DataAccessLayer;
using DEMO_DataAccessLayer.Models;

namespace DEMO_BusinessApplicationLayer.Services
{
    public class LibrosService
    {
        //Inyectar el DEMODbContext que está en Data en la capa DAL

        public string GetLibros()
        {
            return "Todos los Libros"; //Se comunica con DAL para traer los libros desde la BD, usando el dbContext
        }
    }
}
