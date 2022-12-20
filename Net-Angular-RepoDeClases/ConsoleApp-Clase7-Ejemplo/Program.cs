///Usings, arriba
using ConsoleApp_Clase7_Ejemplo;
using OtroNombreDeEspacio.OtroNombre.OtroNombre2;
using OtroNombreDeEspacio.OtroNombre;

///Top-level statements

//namespaces: uso y ejemplos
//Instancia de clase persona en mismo nombre de espacio del proyecto (default) (ver archivos)
var persona = new Persona();
//Instancia de clase persona en otro nombre de espacio, pero en el mismo proyecto (ver archivos)
var persona2 = new OtroNombreDeEspacio.Persona();

//abstract
//Vemos que si queremos instanciar la clase abstracta tenemos error
//var nuevo6 = new EjemploAbstracta();
var nuevo7 = new ClaseNormalQueHeredaDeAbstracta();
nuevo7.Id = 1;
nuevo7.GetOriginalId(); //Llamado al método heredado de la clase abstracta

//internal
//Si queremos instanciar una clase declarada internal en el otro proyecto, tira error
//var instanciaDeInternal = new ConsoleApp_Clase3_Ejemplo.Clases.InternalClass();

//static
var number = StaticClass.GetNumber();
var number2 = NormalClassConStaticMethod.GetNumber();

//También puedo instanciar una clase normal aunque tenga un método estático,
//pero no puedo usar el método estático
var instancia2 = new NormalClassConStaticMethod();
//var number3 = instancia2.GetNumber(); //Da error!

///namespaces y clases, abajo
namespace OtroNombreDeEspacio.OtroNombre
{
    namespace OtroNombre2
    {
        public class OtraClase2
        {

        }
    }

    public class OtraClase
    {
        public OtraClase2 OtraClaseComoProperty { get; set; }
    }
}

public class OtraClase3
{
    public OtraClase OtraClaseComoProperty { get; set; }
}