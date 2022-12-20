using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    /// <summary>
    /// Clase smartphone permite encender, apagar, subir y bajar volumen poner en silencio, bajar o subir brillio
    /// </summary>
    public class Smartphone
    {
        public string marca { get;set; }
        public string modelo { get;set; }

        private Boolean prendido;
        private int volumen;
        private int brillo;

        /// <summary>
        /// constructor minimio para el smartphone con 2 parametros y 3 por default
        /// </summary>
        /// <param name="marca">Marca del equipo</param>
        /// <param name="modelo">Modelo del equipo</param>
        public Smartphone(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.brillo = 50;
            this.volumen = 50;
            this.prendido = false;
        }

        public void encender()
        {
            if (!prendido)
            {
                prendido = true;
                Console.WriteLine("Smartphone encendido");
            }
            else
            {
                Console.WriteLine("El smarphone ya esta encendido");
            }
        }

        public void subirVolumen()
        {
            if (volumen < 100)
            {
                Console.WriteLine("Vol. Actual: "+volumen);
                volumen += 10;
                Console.WriteLine("Vol. +10 = "+volumen);
            }
            else
            {
                volumen = 100;
                Console.WriteLine("Vol. al máximo");
            }

        }
        public void bajarVolumen()
        {
            if(volumen > 10)
            {
                Console.WriteLine("Vol. Actual: " + volumen);
                volumen -= 10;
                Console.WriteLine("Vol. -10: "+volumen);
            }
            else
            {
                Console.WriteLine("Vol. al Mínimo");
                volumen = 10;
            }
        }
        public void mute()
        {
            if(volumen > 0)
            {
                Console.WriteLine("Vol. Actual: " + volumen);
                volumen = 0;
                Console.WriteLine("Vol.en mute = " + volumen);
            }
            else
            {
                Console.WriteLine("Ya esta muteado");
            }
        }
        public void subirBrillo()
        {
            if (brillo < 100)
            {
                Console.WriteLine("Brillo Actual: " + brillo);
                brillo += 10;
                Console.WriteLine("Brillo +10 = "+ brillo);
            }
            else
            {
                brillo = 100;
                Console.WriteLine("Brillo al Máximo");
            }
        }
        public void bajarBrillo()
        {
            if(brillo > 10)
            {
                Console.WriteLine("Brillo Actual: " + brillo);
                brillo -= 10;
                Console.WriteLine("Brillo -10 = "+ brillo);
            }
            else
            {
                brillo = 10;
                Console.WriteLine("Brillo al Mínimo");
            }
        }

    }
}
