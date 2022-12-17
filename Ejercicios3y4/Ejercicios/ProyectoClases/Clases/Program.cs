// See https://aka.ms/new-console-template for more information

//Profe aqui puse la direccion de mi repositorio de git por si no funciona el archivo que subi
// https://github.com/odv144/net-angular/tree/main/Net-Angular-RepoDeClases/ProyectoOmar


//ejercicio 1
/*
int nro;
Console.WriteLine("Ingrese un valor para evaluar");
nro = Int32.Parse(Console.ReadLine());
if (nro > 100)
{
Console.WriteLine("El valor es mayor 100");
}
*/

//ejercicio 2
/*
int nro;
Console.WriteLine("Ingrese un valor para evaluar");
nro = Int32.Parse(Console.ReadLine());
if (nro % 2==0)
{
    Console.WriteLine("El valor ingresado es Par");
}
else
{
    Console.WriteLine("El valor ingresado no es Par");
}
*/

//ejercicio 3
// no pude resolver
/*
int nro;
Console.WriteLine("Ingrese un valor para evaluar");
nro = Int32.Parse(Console.ReadLine());
float simple = (nro / 2);
if (simple %  2 != 0 && (simple *2)==nro )
{
    Console.WriteLine("El valor ingresado Cumple la condicion");
}
else
{
    Console.WriteLine("El valor ingresado no Cumple la condicion");
}
*/

//ejercicio 4
/*
Console.WriteLine("Ingrese un valor entre 1 y 10 a convertir a romano ");
int i=Int32.Parse(Console.ReadLine());
    switch (i)
    {
        case 1:
            Console.WriteLine("I");
            break;
        case 2:
            Console.WriteLine("II");
            break;
        case 3:
            Console.WriteLine("III");
            break;
        case 4:
            Console.WriteLine("IV");
            break;
        case 5:
            Console.WriteLine("V");
            break;
        case 6:
            Console.WriteLine("VI");
            break;
        case 7:
            Console.WriteLine("VII");
            break;
        case 8:
            Console.WriteLine("VIII");
            break;
        case 9:
            Console.WriteLine("IX");
            break;
        case 10:
            Console.WriteLine("X");
            break;
    }
*/

//ejercicio 5
/*

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

if(edad1 < edad2)
{
    Console.WriteLine("El menor es: " + nom1 + " con diferencia de: " + (edad2 - edad1) + " años");
}
else
{
    if(edad2 < edad1)
    {
        Console.WriteLine("El menor es: " + nom2 + " con diferencia de:" + (edad1 - edad2) + " años");
    }
    else
    {
        Console.WriteLine("Ambas personas tienen la misma edad");
    }
}
*/

//ejercicio 6
/*


Console.WriteLine("Ingrese el valor de los 3 lados por separado");
Int32.TryParse(Console.ReadLine(), out int l1);
Int32.TryParse(Console.ReadLine(), out int l2);
Int32.TryParse(Console.ReadLine(), out int l3);
int peri = 0;
double sup = 0;
if(l1==l2 && l2 == l3)
{
    peri = 3 * l1;
    sup = ((Math.Pow(l1, 2))*(Math.Sqrt(3))) / 4;
    Console.WriteLine("El trinángulo es Equilatero con perimetro: "+peri+ " y superficie: "+sup);

}
else
{
    if(l1==l2 || l2 == l3)
    {
        if (l1 == l2)
        {
            peri = 2 * l1 + l3;
            sup = (l3 * (Math.Sqrt((Math.Pow(l1,2)-(Math.Pow(l3,2)/4)))))/2;
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
*/

//ejercicio 7
/*
Console.WriteLine("Ingrese el mondo deseado $");
Int32.TryParse(Console.ReadLine(), out int monto);
int aux = monto;
while (aux > 0){
    int resto = 0;
    int division = 0;
    switch (aux){
        case > 1000:
            division = aux / 1000;
            resto = aux % 1000;
            Console.WriteLine(division + " billete de $1000");
        break;
        case < 1000 and >=500:
            division = aux / 500;
            resto = aux % 500;
            Console.WriteLine(division + " billete de $500");
            break;
        case < 500 and >= 200:
            division = aux / 200;
            resto = aux % 200;
            Console.WriteLine(division + " billete de $200");
            break;

        case <200 and >=100:
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
            Console.WriteLine(division+ " monedas de $2");
            break;
        case < 2 and >= 1:
            division = aux / 1;
            resto = aux % 1;
            Console.WriteLine(division + " monedas de $1");
            break;
    }
    aux = resto;
}
*/
//ejercicio 8
/*
Console.WriteLine("Ingrese un numero hasta el cual quiere imprimir");
Int32.TryParse(Console.ReadLine(), out int nro);
for(int i = 1; i <= nro; i++)
{
    Console.WriteLine(i);
}
*/

//ejercicio 9
/*
int acumulador = 0;
for(int i =1; i <= 15; i++)
{
    Console.WriteLine("Ingrese el " + i + " numero a sumar");
    Int32.TryParse(Console.ReadLine(), out int aux);
    acumulador += aux;
}
Console.WriteLine("La sumatoria de todos los numeros fue: " + acumulador);
*/

//ejercicio 10
/*
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("Ingrese el numero");
    Int32.TryParse(Console.ReadLine(), out int aux);
    if(aux % 3 == 0)
    {
        Console.WriteLine("El numero " + aux + " es multiplo de 3");
    }else
    {
        Console.WriteLine("El numero " + aux + " no es multiplo de 3");
    }
}
*/
//ejercicio 11
/*
string pass;
Console.WriteLine("Ingrese una contraseña");
pass = Console.ReadLine();
string clave = "";
while (clave != pass)
{
    Console.WriteLine("Verifique la igualdad de la contraseña");
    clave = Console.ReadLine();

}
Console.WriteLine("Las contraseñas fueron validadas");
*/

//ejercicio 12
/*
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
        Console.WriteLine("La clave es correcta");
    }
}
*/
//ejercicio 13
/*
int nro = 18;
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
*/
//ejercicio 14
/*
int nro = 18;
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
        if(nro < nro2)
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
*/
//ejercicio 15
/*
string leo ="";
int suma = 0;
do
{
    Console.WriteLine("Ingrese el valor a sumar o fin para terminar");
    leo= Console.ReadLine();
    if (leo!="fin")
    {
        suma += Int32.Parse(leo);
    }
} while (leo != "fin");
Console.WriteLine("La suma fue de " + suma);
*/