﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Clase13_ReverseEngineering.Models
{
    public partial class Questions
    {
        public Questions()
        {
            Ansewers = new HashSet<Ansewers>();
            Intreviews = new HashSet<Intreviews>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Ansewers> Ansewers { get; set; }

        public virtual ICollection<Intreviews> Intreviews { get; set; }
    }
}