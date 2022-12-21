using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Auto
    {
        private string modelo = "";
        private string marca = "";
        private string color = "";
        private Boolean encender;
        private int velocidad;
        private int aceleracion;
        private int _capacidad;
        Persona[] arrayPasajero = new Persona[5];

        public int Pasajeros { get; set; }
        
        public Persona Conductor { get; set; }
        public Mascota animal { get; set; }
        

        public Auto(string modelo, string marca, string color, int capa)
        {
            this.modelo = modelo;
            this.marca = marca;
            this.color = color;
            this.encender = false;
            this.velocidad = 0;
            this.aceleracion = 0;
            _capacidad = capa;
            
        }
        public String Encender()
        {
            if (!encender && Conductor != null)
            {
                if((Conductor.getFechaNac() >= 18))
                {
                    encender = true;
                    return "Auto Encendido";

                }
            }
            return "El coche ya esta encendido o no tiene conductor o el mismo no es mayor de 18";
        }
        public String Apagar()
        {
            if (encender)
            {
                encender = false;
                return "Auto Apagado";
            }
            return "El coche esta apagado no se puede apagar nuevamente";
        }

        public void acelerar()
        {
            if (velocidad < 130 && encender)
            {
                aceleracion += 10;
                velocidad = aceleracion;
                Console.WriteLine($"Velocidad: {velocidad} aceleracion: +10 = {aceleracion}");
            }
            else
            {
                if (encender)
                {
                    Console.WriteLine("Velocidad máxima alcanzada");
                }
                else
                {
                    Console.WriteLine("No se puede acelerar por que coche esta apagado");
                }
            }
        }
        public void frenar()
        {
            if(velocidad > 0)
            {
                aceleracion -= 20;
                velocidad = aceleracion;
                Console.WriteLine($"Velocidad: {velocidad} frenado: -20 = {aceleracion}");
            }
            else
            {            
                Console.WriteLine("El coche esta frenado");
                
            }
        }

        public int getVelocidad()
        {
            return velocidad;
        }
        public int getAceleracion()
        {
            return aceleracion;
        }
        /// <summary>
        /// metodo para asignar un conductor a un coche
        /// </summary>
        public void AsignarConductor()
        {
            Conductor = new Persona();
            Conductor.Nombre = "Jorge Luis";
            Conductor.Apellido = "Martinez";
            Conductor.setFechaNac(new DateTime(1984, 02, 28));

        }

        /// <summary>
        /// Metodo para asignar pasajeros al vehiculo siempre que el vehiculo tenga la capacidad
        /// </summary>
        /// <param name="nro">Es el valor de pasajeros que se agrega</param>
        public void AsignarPasajero(int nro)
        {
            if (Pasajeros == 0)
            {
                Console.WriteLine("La capacidad del vehiculo es: " + _capacidad + " y tiene " + Pasajeros + " pasajeros");
                Pasajeros = nro;
                for (int x=0; x < nro; x++)
                {
                    arrayPasajero[x] = new Persona("Omar"+(x+1),"virili"+ (x + 1), new DateTime(1980+x,5+x,3+x),new Smartphone("Moto"+x,"Modelo"+x));
                }
            }
            else if (_capacidad >= (Pasajeros+nro))
                {
                for (int x = Pasajeros; x < nro; x++)
                {
                    arrayPasajero[x] = new Persona("Omar"+(x+1),"virili"+ (x + 1), new DateTime(1980+x,5+x,3+x),new Smartphone("Moto"+x,"Modelo"+x));
                    
                }
                Pasajeros += nro;
                Console.WriteLine("La capacidad del vehiculo es: " + _capacidad + " y tiene " + Pasajeros + " de pasajeros");
                }else { 
                Console.WriteLine("No se puede agregar más pasajeros capacidad al máximo");
                }
            
        }
        /// <summary>
        /// permite agregar una mascota
        /// </summary>
        /// <param name="aniNombre"></param>
        /// <param name="aniTipo"></param>
        public string  LlevarMascota(Mascota mascota)
        {   //si no hay conductor o capacidad llena no puedo llevar la mascota
            if(Conductor!= null)
            {
                if(Pasajeros == _capacidad-1){

                    if(mascota.Tamanio == "chico")
                    {
                        //ver como hacer pasar asignar el regazo de que pasajero va
                        arrayPasajero[this.Pasajeros-1].RegazoUsado = true;
                        string regazo = arrayPasajero[this.Pasajeros - 1].Nombre;
                        return "La mascota esta en el regazo del pasajero "+ regazo;
                    }
                    else
                    {
                        return "Necesita espacio de un pasajero para poder llevar la mascota";
                    }
                }
                return "Se puede asignar sin problema";
            }
            else
            {

               return "No hay conductor ";
            }
        }
        public void CambiarLugarMascota(int lugar)
        {
            if ( lugar <= _capacidad)
            {
                arrayPasajero[this.Pasajeros].RegazoUsado = false;
                arrayPasajero[lugar].RegazoUsado = true;
            }
        }
        
    }
}
