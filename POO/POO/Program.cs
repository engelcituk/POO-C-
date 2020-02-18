using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.hablar(); // desde aqui se puede elegir que sobrecarga elegir

          
        }

        
    }

    public class Persona
    {
        public Persona() // constructor sin parametros, constructor por defecto
        {
            Console.WriteLine("soy una persona");
            Telefonos = new List<string>();
        }
        //para usar la inicializacion de telefonos en el segundo constructor se agrega el this para llamar el contructor por defecto
        public Persona(string nombre, decimal salarioMensual) : this()
        {
            Nombre = nombre;
            SalarioMensual = salarioMensual;
        }
        public string  Nombre{ get; set; }
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual 
        { 
            get
            {
                return SalarioMensual * 12;
            }
        }
        public List<string> Telefonos { get; set; } // prop de tipo referencia, en el contructor se debe inicializar si se desea manipular
        /*
        No se puede tener dos metodos iguales, a menos que estos tengan parametros diferentes
        los metodos tienen signatura, osea se pueden diferenciar por su nombre y sus paramentros
        */
        public void hablar()
        {

        }
        public void hablar(string mensaje) // al agregar un parametro que lo diferencie del otro metodo similar, significa que se esta sobrecargando el metodo
        {

        }
        public void hablar(string mensaje, int numero) // el orden de los parametros tambien importa, porque pueden tener los mismos parametros, pero si estan en otro orden eso lo hace diferente a otro metodo similar
        {

        }
    }
}
