using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClases.Clases
{
    public class Ejercicios
    {
        private int nro;   
        /// <summary>
        /// Metodo que permite ingresar un numero y ver si es mayor a 100
        /// </summary>
        /// <returns>Retorna un String</returns>
        public string EvaluarNro()
        {
           // int nro = 0;
            Console.WriteLine("Ingrese un valor para evaluar");
            nro = Int32.Parse(Console.ReadLine());
            if (nro > 100)
            {
            return "El valor es mayor 100";
            }
            return "El numero es menor a 100";
        }
        /// <summary>
        /// Funcion para determinar si un numero ingresado es par o impar
        /// </summary>
        public void Par()
        {
     
            // int nro;
            Console.WriteLine("Ingrese un valor para evaluar");
            nro = Int32.Parse(Console.ReadLine());
            if (nro % 2 == 0)
            {
                Console.WriteLine("El valor ingresado es Par");
            }
            else
            {
                Console.WriteLine("El valor ingresado no es Par");
            }
        }
        /// <summary>
        ///  Ejercicio 3 resulte si un numero es el doble de un impar
        /// </summary>
        /// <returns>String indicativo</returns>
        public string Ejercicio3()
        {
            Console.WriteLine("Ingrese un valor para evaluar");
            nro = Int32.Parse(Console.ReadLine());
            float simple = (nro / 2);
            if (simple % 2 != 0 && (simple * 2) == nro)
            {
                return "El valor ingresado Cumple la condicion";
            }
            else
            {
                return "El valor ingresado no Cumple la condicion";
            }
        }
        /// <summary>
        /// Ejercicio4 que permite devolver un numero romano 
        /// </summary>
        /// <returns>String representando el numero en Romano </returns>
        public String Ejercicio4()
        {
            Console.WriteLine("Ingrese un valor entre 1 y 10 a convertir a romano ");
            int i = Int32.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    return ("I");
                    
                case 2:
                    return("II");
                   
                case 3:
                    return ("III");
                    
                case 4:
                    return ("IV");
                    
                case 5:
                    return ("V");
                   
                case 6:
                    return ("VI");
                  
                case 7:
                    return ("VII");
                   
                case 8:
                    return ("VIII");
                    
                case 9:
                    return ("IX");
                    
                case 10:
                    return ("X");
                  
            }
            return "Valor Incorrecto";
        }

        /// <summary>
        /// Lee el nombre y edades de 2 personas y devuelve el del menor 
        /// </summary>
        /// <returns>String informativo </returns>
        public String Ejercicio5()
        {
            Console.WriteLine("Ingrese Nombre de persona 1");
            string nom1 = Console.ReadLine();
            Console.WriteLine("Ingrese la Edad de la persona 1");
            int edad1;
            Int32.TryParse(Console.ReadLine(), out edad1);

            Console.WriteLine("Ingrese Nombre de persona 1");
            string nom2 = Console.ReadLine();
            Console.WriteLine("Ingrese la Edad de la persona 1");
            int edad2;
            Int32.TryParse(Console.ReadLine(), out edad2);

            if (edad1 < edad2)
            {
                return "El menor es: " + nom1 + " con diferencia de: " + (edad2 - edad1) + " años";
            }
            else
            {
                if (edad2 < edad1)
                {
                    return ("El menor es: " + nom2 + " con diferencia de:" + (edad1 - edad2) + " años");
                }
                else
                {
                    return ("Ambas personas tienen la misma edad");
                }
            }
        }

        /// <summary>
        /// Calcula el tipo de trinangulo conociendo sus 3 lados
        /// </summary>
        public void Ejercicio6()
        {
            Console.WriteLine("Ingrese el valor de los 3 lados por separado");
            Int32.TryParse(Console.ReadLine(), out int l1);
            Int32.TryParse(Console.ReadLine(), out int l2);
            Int32.TryParse(Console.ReadLine(), out int l3);
            int peri = 0;
            double sup = 0;
            if (l1 == l2 && l2 == l3)
            {
                peri = 3 * l1;
                sup = ((Math.Pow(l1, 2)) * (Math.Sqrt(3))) / 4;
                Console.WriteLine("El trinángulo es Equilatero con perimetro: " + peri + " y superficie: " + sup);

            }
            else
            {
                if (l1 == l2 || l2 == l3)
                {
                    if (l1 == l2)
                    {
                        peri = 2 * l1 + l3;
                        sup = (l3 * (Math.Sqrt((Math.Pow(l1, 2) - (Math.Pow(l3, 2) / 4))))) / 2;
                    }
                    else
                    {
                        peri = 2 * l3 + l1;
                        sup = (l1 * (Math.Sqrt((Math.Pow(l3, 2) - (Math.Pow(l1, 2) / 4))))) / 2;
                    }

                    Console.WriteLine("El trinángulo es Isósceles con perimetro: " + peri + " y superficie: " + sup);

                }
                else
                {
                    peri = l1 + l2 + l3;
                    double sp = (peri / 2.0);
                    Console.WriteLine(sp);
                    sup = Math.Sqrt(sp * (sp - l1) * (sp - l2) * (sp - l3));
                    Console.WriteLine("El trinángulo es Escaleno con perimetro: " + peri + " y superficie: " + sup);

                }
            }
        }

        /// <summary>
        /// Desglose de un monto dado en billetes y monedas de distintas denominaciones 
        /// </summary>
        public void Ejercicio7()
        {
            Console.WriteLine("Ingrese el mondo deseado $");
            Int32.TryParse(Console.ReadLine(), out int monto);
            int aux = monto;
            while (aux > 0)
            {
                int resto = 0;
                int division = 0;
                switch (aux)
                {
                    case > 1000:
                        division = aux / 1000;
                        resto = aux % 1000;
                        Console.WriteLine(division + " billete de $1000");
                        break;
                    case < 1000 and >= 500:
                        division = aux / 500;
                        resto = aux % 500;
                        Console.WriteLine(division + " billete de $500");
                        break;
                    case < 500 and >= 200:
                        division = aux / 200;
                        resto = aux % 200;
                        Console.WriteLine(division + " billete de $200");
                        break;

                    case < 200 and >= 100:
                        division = aux / 100;
                        resto = aux % 100;
                        Console.WriteLine(division + " billete de $100");
                        break;
                    case < 100 and >= 50:
                        division = aux / 50;
                        resto = aux % 50;
                        Console.WriteLine(division + " billete de $50");
                        break;
                    case < 50 and >= 20:
                        division = aux / 20;
                        resto = aux % 20;
                        Console.WriteLine(division + " billete de $20");
                        break;
                    case < 20 and >= 10:
                        division = aux / 10;
                        resto = aux % 10;
                        Console.WriteLine(division + " billete de $10");
                        break;
                    case < 10 and >= 5:
                        division = aux / 5;
                        resto = aux % 5;
                        Console.WriteLine(division + " monedas de $5");
                        break;
                    case < 5 and >= 2:
                        division = aux / 2;
                        resto = aux % 2;
                        Console.WriteLine(division + " monedas de $2");
                        break;
                    case < 2 and >= 1:
                        division = aux / 1;
                        resto = aux % 1;
                        Console.WriteLine(division + " monedas de $1");
                        break;
                }
                aux = resto;
            }
        }

        /// <summary>
        /// Pide un numero y luego imprime del 1 al número ingresado
        /// </summary>
        public void Ejercicio8()
        {
            Console.WriteLine("Ingrese un numero hasta el cual quiere imprimir");
            Int32.TryParse(Console.ReadLine(), out int nro);
            for (int i = 1; i <= nro; i++)
            {
                Console.Write(i +"-");
            }
        }

        /// <summary>
        /// Pide 15 numeros y devuelve la sumatoria
        /// </summary>
        /// <returns> String devuelve una cadena formateada con la sumatoria</returns>
        public String Ejercicio9()
        {
            int acumulador = 0;
            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine("Ingrese el " + i + " numero a sumar");
                Int32.TryParse(Console.ReadLine(), out int aux);
                acumulador += aux;
            }
            return ("La sumatoria de todos los numeros fue: " + acumulador);
        }

        /// <summary>
        /// Pide 5 números e indica si alguno es multiplo de 3
        /// </summary>
        public void Ejercicio10()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Ingrese el numero");
                Int32.TryParse(Console.ReadLine(), out int aux);
                if (aux % 3 == 0)
                {
                    Console.WriteLine("El numero " + aux + " es multiplo de 3");
                }
                else
                {
                    Console.WriteLine("El numero " + aux + " no es multiplo de 3");
                }
            }
        }

        /// <summary>
        /// Pide un string y luego lo compara con otros ingresado hasta que sean iguales
        /// </summary>
        /// <returns>devuelve un string</returns>
        public string Ejercicio11()
        {
            string pass;
            Console.WriteLine("Ingrese una contraseña");
            pass = Console.ReadLine();
            string clave = "";
            while (clave != pass)
            {
                Console.WriteLine("Verifique la igualdad de la contraseña");
                clave = Console.ReadLine();

            }
            return ("Las contraseñas fueron validadas");
        }

        /// <summary>
        /// Pide un string y lo compara como maximo 3 veces 
        /// </summary>
        /// <returns>String informativo </returns>
        public string Ejercicio12()
        {
            string pass;
            Console.WriteLine("Ingrese una contraseña");
            pass = Console.ReadLine();
            string clave = "";
            int intento = 1;
            while (clave != pass && intento < 4)
            {
                Console.WriteLine("Verifique la igualdad de la contraseña");
                clave = Console.ReadLine();
                if (clave != pass)
                {
                    Console.WriteLine("La clave es incorrecta uso: " + intento + " de 3 permitidos");
                    intento++;
                }
                else
                {
                   return ("La clave es correcta");
                }
            }
            return ("Intentos superados y clave incorrecta");
        }

        /// <summary>
        /// Lee numeros hasta que coincida  en máximo 10 intentos
        /// </summary>
        public void Ejercicio13()
        {
            int intento = 1;
            int nro2 = 0;
            do
            {
                Console.WriteLine("Adivine el numero de 2 cifras oculto");
                Int32.TryParse(Console.ReadLine(), out nro2);
                if (nro == nro2 && intento < 10)
                {
                    Console.WriteLine("FELICIDADES USTED ADIVINO EL NUMERO OCULTO EN: " + intento + " INTENTOS");
                    break;
                }
                else
                {
                    Console.WriteLine("El numero ingresado es incorrecto, intento " + intento + " de 10 permitidos");
                }
                intento++;
            } while (nro == nro2 || intento <= 10);
        }

        /// <summary>
        /// Compara número ingresado con el guardado y da pistas de mayor o menor
        /// </summary>
        public void Ejercicio14()
        {
            nro = 18;
            int intento = 1;
            int nro2 = 0;
            do
            {
                Console.WriteLine("Adivine el numero de 2 cifras oculto");
                Int32.TryParse(Console.ReadLine(), out nro2);
                if (nro == nro2 && intento < 10)
                {
                    Console.WriteLine("FELICIDADES USTED ADIVINO EL NUMERO OCULTO EN: " + intento + " INTENTOS");
                    break;
                }
                else
                {
                    if (nro < nro2)
                    {
                        Console.WriteLine("El numero ingresado es incorrecto y mayor, intento " + intento + " de 10 permitidos");
                    }
                    else
                    {
                        Console.WriteLine("El numero ingresado es incorrecto y menor, intento " + intento + " de 10 permitidos");

                    }

                }
                intento++;
            } while (nro == nro2 || intento <= 10);
        }

        /// <summary>
        /// Sumatoria de N números termina cuando el usuario ingresa "fin"
        /// </summary>
        public void Ejercicio15()
        {
            string leo = "";
            int suma = 0;
            do
            {
                Console.WriteLine("Ingrese el valor a sumar o fin para terminar");
                leo = Console.ReadLine();
                if (leo != "fin")
                {
                    suma += Int32.Parse(leo);
                }
            } while (leo != "fin");
            Console.WriteLine("La suma fue de " + suma);
        }
    }
}
