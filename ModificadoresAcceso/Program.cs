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
        internal string propiedadInterna { get; set; } // solo se accede dentro de este prouyecto ModificadoresAcceso

        protected int propiedadProtegida { get; set; } // solo pueden ser accedidos desde dentro de la clase o desde una clase derivada o hija

        public void MetodoPublico() // metodo publico, se puede usar en cualquier lado
        {
            propiedadPublica = 2;
            metodoPrivado();// se puede llamar el metodo privado porque está dentro de esta clase
            propiedadProtegida = 5; // se puede acceder porque esta dentro de la misma clase
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
            clasePublica.propiedadInterna = "propiedad interna"; // se puede acceder porque es internal

        }
    }
}
/*
 Podemos marcar tipos y miembros como internal para que estos puedan ser accedidos dentro del mismo proyecto, no de externos
     */