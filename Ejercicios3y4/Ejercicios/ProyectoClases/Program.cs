using ProyectoClases.Clases;
using System.Reflection.PortableExecutable;
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
/*
Persona usuario = new Persona();
usuario.setFechaNac(new DateTime(1984, 02, 28));
Console.WriteLine(usuario.getFechaNac());
*/
#endregion

#region Ejercicio 5 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo");
Console.WriteLine(coche.Encender());
Console.WriteLine(coche.Encender());
Console.WriteLine(coche.Apagar());
Console.WriteLine(coche.Apagar());
*/
#endregion

#region Ejercicio 6 de la guia 2
/*
Mascota animal = new Mascota("Uma",0);
Console.WriteLine(animal.getNombre());
Console.WriteLine(animal.tipo);
animal.alimentar();
Console.WriteLine(animal.getEnergia());
animal.alimentar();
Console.WriteLine(animal.getEnergia());
for(int i = 0; i < 10; i++)
{
    animal.alimentar();
    Console.WriteLine(animal.getEnergia());
}

*/
#endregion

#region Ejercicio 7 de la guia 2
/*
Mascota animal = new Mascota("Uma", 0);
while(animal.energia<100)
{
    animal.alimentar();
    Console.WriteLine(animal.energia);
}

while (animal.energia>20)
{
    animal.correr();
    Console.WriteLine(animal.energia);
}
*/

#endregion

#region Ejercicio 8 de la guia 2
/*
Smartphone celu = new Smartphone("LG", "K50");
Console.WriteLine($"Marca: {celu.marca}, Modelo:{celu.modelo}");
celu.encender();
for(int i = 0; i < 10; i++)
{
celu.subirVolumen();

}
for (int i = 0; i < 10; i++)
{

celu.subirBrillo();
}
for (int i = 0; i < 10; i++)
{

celu.bajarVolumen();
}
for (int i = 0; i < 10; i++)
{

celu.bajarBrillo();
}
celu.mute();
celu.mute();
*/

#endregion

#region Ejercicio 9 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo");
coche.acelerar();
Console.WriteLine(coche.Encender());
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.frenar();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.acelerar();
coche.frenar();


Console.WriteLine($"Velocidad: {coche.getVelocidad()}");
Console.WriteLine($"Aceleracion: {coche.getAceleracion()}");

Console.WriteLine(coche.Apagar());
*/

#endregion

#region Ejercicio 10 de la guia 2
/*
DateTime naci = new DateTime(1984, 02, 28);
Smartphone celu = new Smartphone("Samsung", "J2");
Persona cliente = new Persona("Omar Dario","Virili",naci,celu);
cliente.MostrarDatos();
*/

#endregion

#region Ejercicio 11 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo");

coche.AsignarConductor();
Console.WriteLine(coche.Encender());
Console.WriteLine(coche.Apagar());
*/
#endregion

#region Ejercicio 12 de la guia 2
/*
Auto coche = new Auto("Fuego", "Renault", "Rojo");
coche.Capacidad = 5;
coche.AsignarPasajero(3);
*/

#endregion

#region Ejercicio 13 de la guia 2

Auto coche = new Auto("Fuego", "Renault", "Rojo",5);
Mascota animal = (new Mascota("Tilin", Mascota.TipoAnimal.perro));

coche.AsignarConductor();
coche.AsignarPasajero(4);
animal.Tamanio = "Grande";
Console.WriteLine(coche.LlevarMascota(animal));
//Tarea: Hacer el cambio de regazo de la mascota eh implementar lo del tamaño del animal


#endregion

#region Ejercicio 14 de la guia 2




#endregion

#region Ejercicio 15 de la guia 2



#endregion