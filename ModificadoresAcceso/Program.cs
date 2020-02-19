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
        internal string propiedadInternal { get; set; } // solo se accede dentro de este proyecto ModificadoresAcceso

        protected int propiedadProtegida { get; set; } // solo pueden ser accedidos desde dentro de la clase o desde una clase derivada o hija

        protected internal string propiedadProtegidaInternal { get; set; }/*
        puede ser accedido desde cualquier lugar dentro del proyecto y desde fuera del proyecto a traves de una clase derivada
         */
          
        private protected int propiedadPrivateProtected { get; set; } /* Este solamente puede ser accedido desde dentro de la misma clase o una clase derivada, que se encuentre dentro del mismo proyecto
        */
        public void MetodoPublico() // metodo publico, se puede usar en cualquier lado
        {
            propiedadPublica = 2;
            propiedadProtegida = 5; // se puede acceder porque esta dentro de la misma clase
            propiedadProtegidaInternal = "hola mundo"; // se puede acceder dentro del mismo proyecto
            propiedadPrivateProtected = 985; // puedo acceder a este propiedad  private protected porque estoy en la misma clase 

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
            clasePublica.propiedadInternal = "propiedad interna"; // se puede acceder porque es internal,accesible en todo el proyecto

            clasePublica.propiedadProtegidaInternal = "hey dude"; // puedo acceder porque pertenece al proyecto, en otro proyecto se podría solo si la clase donde se invoca sea derivada de otra con este modificador de acceso (protected internal)

            //clasePublica.propiedadPrivateProtected = 48; //ERROR: no puedo acceder porque esta propiedad private protected no le pertenece a esta clase ni es una clase derivada

        }
    }

    public class ClaseDerivada: ClasePublicaDePrueba
    {
        public void metodoDePrueba()
        {
            propiedadPrivateProtected = 567; //  puedo acceder a esta propiedad private protected porque estamos en una clase derivada y está en el mismo proyecto
        }
    }
}
/*
 Podemos marcar tipos y miembros como internal para que estos puedan ser accedidos dentro del mismo proyecto, no de externos
     */