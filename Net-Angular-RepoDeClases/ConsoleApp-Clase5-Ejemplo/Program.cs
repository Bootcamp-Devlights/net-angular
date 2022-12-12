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

public class MiClase
{
    public int id;
    public string name;
}