using System;

namespace ModificadoresAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class ClasePublicaDePrueba // clase publica, se puede usar en cualquier lado
    {
        public int propiedadPublica { get; set; } // propiedad publica, se puede usar en cualquier lugar donde se instancie la clase
       
        public void MetodoPublico() // metodo publico, se puede usar en cualquier lado
        {
            propiedadPublica = 2;
            metodoPrivado();// se puede llamar el metodo privado porque está dentro de esta clase
        }

        private void metodoPrivado() // este metodo privado se puede invocar solo dentro de la clase, no fuera de ella
        {

        }
    }

    public class ClasePublicaCliente
    {
        public void metodoPrueba()
        {
            var clasePublica = new ClasePublicaDePrueba(); // instancio
            clasePublica.MetodoPublico(); // solo tengo acceso al metodo publico, no al privado  metodoPrivado()
            // clasePublica.metodoPrivado(); // error, es privado
        }
    }
}
