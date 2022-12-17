using ProyectoClases.Clases;
#region Ejercicio 1 de la guia 2
/*
Ejercicios ObjEjercicio = new Ejercicios();
Console.WriteLine(ObjEjercicio.EvaluarNro());
ObjEjercicio.Par();
Console.WriteLine(ObjEjercicio.Ejercicio3());
Console.WriteLine(ObjEjercicio.Ejercicio4());
Console.WriteLine(ObjEjercicio.Ejercicio5());
ObjEjercicio.Ejercicio6();
ObjEjercicio.Ejercicio7();
ObjEjercicio.Ejercicio8();
Console.WriteLine(ObjEjercicio.Ejercicio9());
ObjEjercicio.Ejercicio10();
Console.WriteLine(ObjEjercicio.Ejercicio11());
Console.WriteLine(ObjEjercicio.Ejercicio12());
ObjEjercicio.Ejercicio13();
ObjEjercicio.Ejercicio14();
ObjEjercicio.Ejercicio15();
*/
#endregion

#region Ejercicio 2 de la guia 2
/*
var Obj = new Cuadrado();
Console.WriteLine("Ingrese el valor del lado del cuadrado a calcular");
Double.TryParse(Console.ReadLine(), out Double nro);
Console.WriteLine((Obj.Area(nro)).ToString());
*/
#endregion

#region Ejercicio 3 dde la guia 2
/*
Persona usuario = new Persona();
Console.WriteLine(usuario.NombreCompleto("Omar","Virili"));
*/
#endregion

#region Ejercicio 4 de la guia 2

Persona usuario = new Persona();
usuario.setFechaNac(new DateTime(1984, 02, 28));
Console.WriteLine(usuario.getFechaNac());

#endregion