#region Array
///Array single dimensional or unidimensional
//1ra forma de declaración
int[] arreglo1 = new int[10]; //Índice de 0 a 9
//Indice Siempre es un entero
//Setear un valor del arreglo (usando el índice)
arreglo1[0] = 1;
arreglo1[9] = 10;
Console.WriteLine("Longitud: " + arreglo1.Length);
Console.WriteLine("Primer elemento: " + arreglo1[0]);
Console.WriteLine("Último elemento: " + arreglo1[arreglo1.Length - 1]);
Console.WriteLine("Rank: " + arreglo1.Rank);

//2da forma de declaración
int[] arreglo2 = new int[] { 1, 2, 3, 4 };
Console.WriteLine("Longitud: " + arreglo2.Length);
Console.WriteLine("Primer elemento: " + arreglo2[0]);
Console.WriteLine("Último elemento: " + arreglo2[arreglo2.Length - 1]);

//3ra forma de declaración
int[] arreglo3 = { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("Longitud: " + arreglo3.Length);
Console.WriteLine("Primer elemento: " + arreglo3[0]);
Console.WriteLine("Último elemento: " + arreglo3[arreglo3.Length - 1]);

for (int i = 0; i < arreglo1.Length; i++)
{
    arreglo1[i] = i + 1;
}

foreach(int item in arreglo1)
{
    Console.WriteLine(item);
}

///Array multidimensional
int[,] arreglo2dim = new int[3,3];
Console.WriteLine(arreglo2dim[0,0]);
Console.WriteLine("Rank: " + arreglo2dim.Rank);
//Índices - Combinaciones:
///0,0
///0,1
///0,2
///1,0
///1,1
///1,2
///2,0
///2,1
///2,2

//(0,0),(0,1),(0,2)
//(1,0),(1,1),(1,2)
//(2,0),(2,1),(2,2)
Console.WriteLine(arreglo2dim.Length);

//Recorrido y asignación de valores
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        arreglo2dim[i, j] = i + j;
    }
}

//Recorrido
foreach (int item in arreglo2dim)
{
    Console.WriteLine(item);
}

///Array Jagged (Arreglo de arreglos)
///[ [] , []  , [] ]
int[][] arregloJagged = new int[3][];
arregloJagged[0] = new int[3] { 1, 2, 3 };
arregloJagged[1] = new int[4] { 1, 2, 3, 4 };
arregloJagged[2] = new int[5] { 1, 2, 3, 4, 5 };
Console.WriteLine(arregloJagged[0][1]);
Console.WriteLine(arregloJagged[1][3]);
Console.WriteLine(arregloJagged[2][0]);

Console.WriteLine("Rank: " + arregloJagged.Rank);
Console.WriteLine("Rank: " + arregloJagged[0].Rank);
Console.WriteLine("Rank: " + arregloJagged[1].Rank);
Console.WriteLine("Rank: " + arregloJagged[2].Rank);

for (int i = 0; i < arregloJagged.Length; i++)
{
    for (int j = 0; j < arregloJagged[i].Length; j++)
    {
        arregloJagged[i][j] = i + j;
    }
}

foreach (int[] item in arregloJagged)
{
    foreach (int item2 in item)
    {
        Console.WriteLine(item2);
    }
};

#endregion

#region List
//1ra forma
List<string> lista1 = new List<string>();
Console.WriteLine("Count: " + lista1.Count);
Console.WriteLine("Capacity: " + lista1.Capacity);

//2da forma
List<int> lista2 = new List<int>(arreglo1);
Console.WriteLine("Count: " + lista2.Count);
Console.WriteLine("Capacity: " + lista2.Capacity);

//3ra forma
List<MiClase> lista3 = new List<MiClase>(3);
Console.WriteLine("Count: " + lista3.Count);
Console.WriteLine("Capacity: " + lista3.Capacity);

//4ta forma
List<int> lista4 = new List<int>() { 1, 2, 3, 4, 5, 6 };
Console.WriteLine("Count: " + lista4.Count);
Console.WriteLine("Capacity: " + lista4.Capacity);

for (int i = 0; i < lista4.Count; i++)
{
    lista4[i] = i + 1;
    Console.WriteLine(lista4[i]);
}

foreach(var item in lista4)
{
    Console.WriteLine(item);
}

lista4.Add(1);
lista4.Add(2);
lista4.Add(3);

foreach (var item in lista4)
{
    Console.WriteLine(item);
}

Console.WriteLine("Count: " + lista4.Count);
Console.WriteLine("Capacity: " + lista4.Capacity);

#endregion

#region ArrayMethods
///Array - Methods
Array.Clear(arreglo1);
var nuevoArreglo = arreglo1.Clone();

Array.Copy(arreglo1, arreglo2, 10);
arreglo1.CopyTo(arreglo2, 10);

// parametros (nombres) => deficion
//Pregunta si en arreglo1 "Existe" un item que "cumpla con la condición del predicado"
var flag = Array.Exists(arreglo1, item => item == 2 );

var primervalor = Array.Find(arreglo1, item => item > 0);
var ultimovalor = Array.FindLast(arreglo1, item => item > 0);

var valores = Array.FindAll(arreglo1, item => item > 0);

var indiceprimero = Array.FindIndex(arreglo1, item => item > 0);
if(indiceprimero < 0)
{
    //No existe un elemento que cumpla la condición
}
else
{
    //existe un elemento
}

var indiceultimo = Array.FindLastIndex(arreglo1, item => item > 0);
if (indiceultimo < 0)
{
    //No existe un elemento que cumpla la condición
}
else
{
    //existe un elemento
}

Array.ForEach(arreglo1, 
    item => {
        if (item > 2)
            item--;
        else
            item++;
    }
);

var longitud = arreglo1.GetLength(1);
var item = arreglo1.GetValue(2);
//var item = arreglo1[2];
arreglo1.SetValue(8, 2);
//arreglo1[2] = 8;
var arregloreverted = arreglo1.Reverse();

var indice2 = Array.IndexOf(arreglo1, 8);
Array.Resize(ref arreglo1, 15);
Array.Sort(arreglo1);
#endregion

#region ListMethods
lista1.Add("palabra2");
lista2.AddRange(lista4);
lista2.Clear();
var flag2 = lista1.Contains("palabra");
lista2.CopyTo(arreglo1);
lista2.Equals(lista4);
var flag3 = lista1.Exists(item => item == "palabra");
var valorString = lista1.Find(item => item.Contains('p'));
lista1.ForEach(item =>
{
    item = item.ToUpper();
});
var indicePalabra = lista1.IndexOf("palabra");

lista2.Insert(2, 5);
lista2.InsertRange(2, lista4);
lista2.Remove(8);
lista2.RemoveAll(item => item < 0);
lista2.RemoveRange(2, 5);
lista2.RemoveAt(2);
lista2.Reverse();
lista2.Sort();

//join, union, select, where, order
var flag4 = lista2.All(item => item > 0);
var flag5 = lista2.Any(item => item > 0);
var listanueva = lista2.Concat(lista4);
var listaunica = lista2.Distinct();
var element = lista1.ElementAt(2);
var listaExcept = lista2.Except(lista4);
var element2 = lista1.First(item => item == "hola mundo");
var element3 = lista1.FirstOrDefault(item => item == "hola mundo");
var element4 = lista3.FirstOrDefault(item => item.id > 0 && item.name == "");
//Last
//LastOrDefault

var valor5 = lista2.Max();
var valor4 = lista3.Max(item => item.Score);

var nuevaLista2 = lista3.Where(o => o.Score > 50).Select(item => item.Score).Sum();
var ordererLista = lista3.OrderBy(o => o.Score);
//lista2.Join(lista4, x => x, x => x, x => x);
var nuevaLista3 = lista2.Union(lista4);

#endregion

public class MiClase
{
    public int id;
    public string name;

    public int Score { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="num"></param>
    /// <returns></returns>
    public int MyMethod(int num)
    {
        Console.WriteLine();
        return 1;
    }
}