using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Clase7_Ejemplo
{
    public interface IEjemploInterfaz //Solo para comparación con la clase abstracta
    {
        public int Id { get; set; }

        protected int MetodoAbstracto();
        //En realidad este método no es abstracto en la interfaz
        //Ponemos el mismo nombre, simplemente para comparar con la clase abstracta
        //Ya que al implementar la interfaz, obliga a su implementación
        //Está marcado como protected
    }

    public abstract class EjemploAbstracta
    {
        public int Id { get; set; }

        public abstract void MetodoAbstracto(); //Método abstracto de clase abstracta. Sin implementación

        //Método marcado para sobreescritura opcional en una futura derivación. Debe tener implementación
        public virtual int MetodoParaSobreescribir_Opcional()
        {
            return Id;
        }

        //Método marcado como protected. Accesible sólo en derivación
        protected int MetodoProtected1()
        {
            return 3;
        }
    }

    //Heredando una clase abstracta, en una clase normal
    public class ClaseNormalQueHeredaDeAbstracta: EjemploAbstracta
    {
        public int GetOriginalId()
        {
            //Llamado al método para sobreescribir, sin sobreescribir
            return MetodoParaSobreescribir_Opcional();
        }

        //Se debe implementar sí o sí el método abstracto al derivar la clase abstracta, igual que en la interfaz
        public override void MetodoAbstracto()
        {
            MetodoProtected1(); //Llamando al método protected luego de la derivación
        }

        //Sobreescribiendo el método, y sellándolo para futuras derivaciones
        public sealed override int MetodoParaSobreescribir_Opcional()
        {
            return 8;
        }

        //Método marcado como protected en una clase normal
        protected void MetodoProtected2()
        {

        }
    }

    //Heredando una clase normal, que a su vez hereda una clase abstracta, y ahora sellándola
    public sealed class ClaseNormalAhoraSellada: ClaseNormalQueHeredaDeAbstracta
    {
        //Intentando sobreescribir el método sellado anterior tira error
        //public override int MetodoParaSobreescribir_Opcional()
        //{

        //}

        public void MetodoNormal()
        {
            MetodoProtected2(); //Llamando al método protected de la clase normal, pero al derivar de ella
        }
    }

    //Intentando derivar nuevamente la clase anterior sellada tira error
    //public class OtraClaseNormal: ClaseNormalAhoraSellada
    //{

    //}
}
