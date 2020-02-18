using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona();
            persona1.Telefonos.Add("9845959345");

            //uso de segundo constructor
            var persona2 = new Persona("Manuel", 1500); //ocupo el segundo constructor
            persona2.Telefonos.Add("5675675995"); // es diferente porque en este no se inicializa list de telefonos

        }

        public static void cambiarNombre(Persona persona)
        {
            persona.Nombre = "Nuevo nombre";
        }
        
        // public static void aumentar( int numero) // no tiene ref
        public static void aumentar(ref int numero) // con ref, para que se comporte como referencia
        {
            numero++;
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

    }
}
