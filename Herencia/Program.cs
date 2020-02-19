﻿using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
           // var perro = new Perro(); // se instancia perro
            Animal perrito = new Perro(); // se instancia perro, es de tipo animal
            /*como animal es una clase de tipo abstracto no se puede instanciar*/
           // perrito.HacerRuido();

            ProcesarAnimal(perrito);
            ProcesarAnimal(new Gato());
            static void ProcesarAnimal(Animal animal)
            {
                animal.HacerRuido();
                animal.comerCarne();

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

        
        public virtual void comerCarne()
        {
            /* Un metodo virtual es aquel que puede ser sobrescrito por una clase derivada y que tiene implementación, en c# los metodos son "NO VIRTUALES".
          Para sobrescribir un metodo virtual,se hace igual como se hace con los metodos abstractos, se usa override
    */
            Console.WriteLine("comer carne yumi yumi");

        }
    }
    public class Perro : Animal
    {
        public override void HacerRuido() // HacerRuido metodo abstracto implementado, se sobreescribe
        {
            Console.WriteLine("woof woof");
        }

        public override void comerCarne() // comerCarne metodo virtual implementado sobrescrito
        {
            Console.WriteLine("woof woof como carne");
        }

    }
    public class Gato : Animal
    {
        public override void HacerRuido() // HacerRuido metodo abstracto implementado,se sobreescribe  
        {
            Console.WriteLine("miau miau");

        }
        // comerCarne metodo virtual si es implementado en esta clase, pero no es sobrescrito
    }



}
