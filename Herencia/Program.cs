using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
           // var perro = new Perro(); // se instancia perro
            Animal perrito = new Perro(); // se instancia perro, es de tipo animal
            /*como animal es una clase de tipo abstracto no se puede instanciar*/
            perrito.HacerRuido();

            ProcesarAnimal(perrito);
            ProcesarAnimal(new Gato());
            static void ProcesarAnimal(Animal animal)
            {
                animal.HacerRuido();
            }


        }
    }

    public class Persona : Entidad // la clase hija es persona y entidad es la clase base, entidad le hereda a Persona
    {
        public int Nombre { get; set; }
        
    }

    public class Producto : Entidad // la clase hija es Producto y entidad es la clase base, entidad le hereda a Persona
    {
        public int Decripcion { get; set; }

        public decimal precio { get; set; }
    }

    /*
     * una clase abstracta no puede ser instanciada, y su proposito es servir de clase base para otras clases
     */
    public abstract class Animal
    {
        
        public abstract void HacerRuido(); /* en lugar de void se puede indicar el valor de salida(string..), y tambien los valores de entrada
         */
        /*un metodo abstracto solo se puede crear en una clase abstracta, pero no tiene implementacion, solo se implementa en las clases derivadas 
         */

    }
    public class Perro : Animal
    {
        public override void HacerRuido() // HacerRuido metodo abstracto implementado
        {
            Console.WriteLine("woof woof");
        }
    }
    public class Gato : Animal
    {
        public override void HacerRuido() // HacerRuido metodo abstracto implementado
        {
            Console.WriteLine("miau miau");

        }
    }

}
