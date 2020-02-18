using System;
using System.Collections.Generic;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona() { FechaNacimiento = new DateTime(1980, 5, 8) };
            Console.WriteLine($"La edad de la persona es {persona.Edad}");

            string text = null;
            var resultado = text.ContarVocales();
            Console.WriteLine($"La cantidad de vocales son: {resultado}");


        }
        public static void ProcesarRepositorio(IRepositorioPersonas repositorio)
        {
            repositorio.ObtenerPersonas();
        }

        //hacerlo mas dinamico, programar para la interfaz
        enum TipoRepositorio { Memoria = 1, BD = 2}

        // esto es un metodo para hacer dinamico el uso de la interfaz
        static IRepositorioPersonas ObtenerRepositorio(TipoRepositorio tipoRepositorio)
        {
            switch (tipoRepositorio)
            {
                case TipoRepositorio.Memoria:
                    return new RepositorioPersonasEnMemoria();                    
                case TipoRepositorio.BD:
                    return new RepositorioPersonasDB();
                default:
                    throw new NotImplementedException();
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
        public DateTime FechaNacimiento { get; set; }
        public int Edad
            { get
                {
                    return FechaNacimiento.CalcularEdad(); // un metodo de extension es una manera abreviada de invocar un metodo estatico  
                   // return UtilidadesFechas.CalcularEdad(FechaNacimiento); // clase estatica, por eso no se instancia
                }

            }
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
}