/////Clase 2
/*
A continuación, un compendio de líneas de ejemplo de lo que vimos en la clase 2, que pueden utilizar para realizar los ejercicios. 
*/
#region Built-in_Types
////Built-in Types
//numericos
///Value Types
byte tipo1;
sbyte tipo2;
short tipo3;
ushort tipo4;
int tipo5 = 150;
ushort tipo6;
long tipo7 = 123546;
ulong tipo8;
float tipo9;
double tipo10 = 1.0;
decimal tipo11 = 12356.12m;
//otros
char tipo12 = 'C';
bool tipo13 = true;

///Reference Types
string tipo14 = "palabra";

//Algunos de las anteriores variables fueron inicializadas, otras no
//También se puede inferir el tipo de dato usando var (es decir, dejar que el framework deduzca el tipo de dato según el valor asignado)
//ej
var numero = 1;

/*
 Recuerden que las variables pueden tener cualquier nombre, pero respetando lo siguiente:
puede:
empezar por "_".
contener caracteres Unicode en mayúsculas y minúsculas (sensible a mayúsculas y minúsculas).

no puede:
empezar por un número.
empezar por un símbolo, ni aunque sea una palabra clave.
contener más de 511 caracteres.
 */
#endregion

#region Casteos
////Casteos
//Para las conversiones o casteos, se usa:
long valorCasteado = 123; // Conversión implícita (de int a long)
int valorCasteado2 = (int)valorCasteado; // Conversión explícita (de long a int)
//En algunos casos no se puede hacer una conversión de forma explícita ni directa, por lo que se recurren a otros métodos,
//como se ve más adelante en el ejemplo de String a Int

//Recuerden mirar la tabla para ver si la conversión es posible!
#endregion

#region Operadores
////Operadores
///Aritméticos
var valorCalculado = (((1 + 6) / 7) - 1) * 2;

//El operador % se usa igual que la división sólo que devuelve el resto. El operador / devuelve siempre la operación completa, con decimales si es necesario

///Incremento, de a 1
var incremento = 1;
incremento++; //Incrementa la variable en uno, a partir de aquí el valor es 2

///Concatenación
var saludo = "Hola " + "Mundo";

///Lógicos y Relacionales
//Esto se va a ver mejor cuando se usen los condicionales, pero los operadores son

//Lógicos
//    !  NOT o Negación
//    && AND
//    || OR

//Relacionales
//    == (Comprueba si son iguales)
//    != (Comprueba si son distintos)
//    < (Comprueba si izquierdo es menor a derecho)
//    > (Comprueba si izquierdo es mayor a derecho)
//    <= (Comprueba si izquierdo es menor o igual a derecho)
//    >= (Comprueba si izquierdo es mayor o igual a derecho)

//Para mayor comprensión se recomienda usar paréntesis
#endregion

#region EstructurasDeControl
////Esctructuras de Control
///Condicionales
//if (solamente)
if (incremento == 2)
{
    Console.WriteLine("ES DOS");
}
//Si el statement va a ser de una sola línea, se pueden eliminar las llaves
if (incremento == 2)
    Console.WriteLine("ES DOS");

//if-else
if ((incremento % 2) == 0)
{
    Console.WriteLine("ES PAR");
}
else
{
    Console.WriteLine("NO ES PAR. ES IMPAR");
}

//Lo mismo que el anterior, con el statement de una sola línea
if ((incremento % 2) == 0)
    Console.WriteLine("ES PAR");
else
    Console.WriteLine("NO ES PAR. ES IMPAR");

//Aquí se puede utilizar el llamado operador ternario usando ? y :
var texto = (incremento % 2) == 0 ? "ES PAR" : "NO ES PAR. ES IMPAR";
Console.WriteLine(texto);
//Podría ir todo dentro del WriteLine, pero realizamos la asignación a una variable para que lo entiendan mejor
//El operador ternario se puede anidar, así como los if-else

//if-elseif-else
if ((incremento % 2) == 0)
{
    Console.WriteLine("ES PAR");
}
else if ((incremento % 3) == 0)
{
    Console.WriteLine("ES IMPAR");
}
else
{
    Console.WriteLine("NO SE QUE ES");
}

//Switch. Existe para básicamente evitar el anidamiento de if-else
//Se lo usa cuando existen más de dos condiciones a evaluar
switch (incremento)
{
    case 1:
        Console.WriteLine("UNO");
        break;
    case 2:
    case 3:
        break;
    case <= 0:
        Console.WriteLine("MENOR O IGUAL A CERO");
        break;
    case > 0 and <= 10:
        Console.WriteLine("MAS GRANDE QUE CERO Y MENOR A DIEZ");
        break;
    case > 10:
        Console.WriteLine("MAYOR A DIEZ");
        break;
    default:
        break;
}

//Una nueva forma de escribir la sentencia Switch en C#
var message = incremento switch
{
    <= 0 => "Less than or equal to 0",
    > 0 and <= 10 => "More than 0 but less than or equal to 10",
    _ => "More than 10"
};
Console.WriteLine(message);

//Switch con rango de datos, y variables locales
int valor = 63;
switch (valor)
{
    case int n when (n >= 100):
        Console.WriteLine($"I am 100 or above: {n}");
        break;

    case int n when (n < 100 && n >= 50):
        Console.WriteLine($"I am between 99 and 50: {n}");
        break;

    case int n when (n < 50):
        Console.WriteLine($"I am less than 50: {n}");
        break;
}

///Repetitivas
//for
//Se ejecuta una x cantidad de veces
for (int i = 0; i < 10; ++i)
{
    Console.WriteLine(i);
}

//while
//Se ejecuta mientras se siga cumpliendo la condicion
while (incremento < 10)
{
    Console.WriteLine(incremento);
    incremento++;
}
//Se debe tener cuidado de incrementar la variable de control o de estar seguros de que la condición se va a romper en algún momento
//De lo contrario podemos caer en un loop infinito

//do-while
//Se ejecuta hasta que se deje de cumplir la condición
do
{
    Console.WriteLine(incremento);
    incremento++;
} while (incremento < 20);
//Se debe de tener el mismo cuidado que con el while, de no caer en un loop infinito

//La principal diferencia del while y el do-while
//Es que el while puede no ejecutarse nunca, ya que la condición se evalua antes del statement
//En cambio el do-while se ejecuta al menos una vez, ya que la condición se evalúa después del statement; sí o sí una vez

//foreach
//Es un for resumido, que se usa para recorrer elementos de un conjunto de datos
//Por ahora lo usaremos con el tipo string, que es un conjunto de char
string cadena = "Un conjunto de caracteres";
foreach (char c in cadena)
{
    Console.WriteLine(c);
}
#endregion

#region Extras
//// Extras
//Esto es un comentario de una sóla línea
/*
Esto
Permite
Ingresar
Comentarios
De Varias
Líneas
*/

/*
Se puede usar los siguientes comandos de la clase Console, para mostrar datos por consola
Y para recibir datos.
Tener en cuenta que los datos recibidos siempre son de tipo string, y el usuario puede no ingresar nada,
por lo que se debería controlar que el valor ingresado no sea nulo (null)
*/

Console.WriteLine("Mostrar texto por consola"); //Escribe en la consola lo que le pasemos
var option = Console.ReadLine(); //Lee de la consola

//ReadLine muestra un cursor en la consola esperando a que el usuario ingrese algo y presione enter, o cierre la aplicación
//Lo que "leemos" de la consola puede guardarse en una variable y utilizarse para cualquier cálculo
//Y se puede "leer" de la consola la cantidad de veces que necesitemos

//Para convertir una variable que leemos en entero, podemos usar
int num = Int32.Parse(option);
//Pero Parse no tiene en cuenta si option es null o vacío, por lo que podríamos caer en un error

//En su lugar podríamos hacer
Int32.TryParse(option, out num);
Console.WriteLine(num);
//Donde TryParse convierte a int checkeando primero si es null o no y lo guarda en la variable que le pasemos luego de 'out'. La diferencia es que requiere una entrada y una variable de salida
#endregion
