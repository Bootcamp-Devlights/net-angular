///Arriba: using
using ConsoleApp_Clase3_Ejemplo;
using ConsoleApp_Clase3_Ejemplo.Clases;

///Top-Level Statements
///Instanciación y seteo de properties
///
//Instanciamos un estudiante
Estudiante unEstudiante = new Estudiante();
//Y luego le asignamos valores a sus properties
unEstudiante.Nombre = "Nombre";
unEstudiante.Apellido = "Apellido";
unEstudiante.DateOfBirth = new DateTime(2000, 12, 01);
unEstudiante.SetEdad(25);
unEstudiante.GetEdad();
unEstudiante.Edad = 25;
unEstudiante.Enum = MyEnum.Uno;
unEstudiante.PhoneType = PhoneTypeEnum.Mobile;
unEstudiante.CompleteAddress = new Address() { Street = "Una Calle", Number = 123, City = "Corrientes", Country = "Argentina" };


Console.WriteLine(unEstudiante.Edad);
Console.WriteLine(unEstudiante.Enum);
Console.WriteLine(unEstudiante.GetCompleteAddressAsString());

//O bien usamos el constructor custom que definimos y le pasamos los valores en el constructor
var nuevoEstudiante2 = new Estudiante(30, "nombre", "apellido", 12345678);
//O si no tenemos constructor, podemos instanciar y en la misma línea setearle las properties
Autor unAutor = new Autor() { Nombre = "autorcito", Apellido = "perez", Edad = 30 };
Libro unLibro = new Libro();
unLibro.Autor = unAutor; //Acá vemos cómo podemos pasarle una instancia de autor a la property del libro, del tipo Autor
Console.WriteLine(unAutor.GetCompleteAddressAsString());
///Uso de las properties y métodos
///
Console.WriteLine(unLibro.Autor.Nombre); //Y acá vemos cómo podemos acceder a la property Nombre del autor del libro

string nombreCompleto = unEstudiante.GetNombreCompleto(); //Acá vemos cómo podemos llamar al método de una instancia de estudiante, que nos devuelve el nombre completo
var nombreCompleto2 = nuevoEstudiante2.GetNombreCompleto(); //Vemos tb que cualquier instancia de la misma clase tiene los métodos de dicha clase

Console.WriteLine(nombreCompleto);
Console.WriteLine(nombreCompleto2);

Console.WriteLine(unEstudiante.GetDateOfBirth());

///Abajo: namespaces y classes