﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication_MVC.Models
{
    public class Libro
    {
        public int Id { get; set; }

        //Properties
        public string Titulo { get; set; }
        public int CantDePaginas { get; set; }
        public string NombreAutor { get; set; } //En este caso podemos definir una property para el nombre del autor como string
        //public Autor Autor { get; set; } //O bien colocar una property que sea de la clase Autor

        //Ambos están bien, va a depender de qué tanta información requerimos del autor, y si lo queremos como clase o simplemente el nombre como string

        //Clase sin métodos, sin constructor
    }

    //Models: Clases - Nombre Normal sin Model
    //Controllers: Clases (Particulares) - Nombre tiene que llevar Controller al final - Relacionado a un Model
}
