using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Juan" }; // una instancia de una clase es un tipo de referencia 
            Console.WriteLine($"Nombre antes del cambio: {persona1.Nombre}");
            cambiarNombre(persona1); //se hace el cambio por referencia
            Console.WriteLine($"Nombre despues del cambio: {persona1.Nombre}");

            var numero = 5;// este tipo entero es un tipo de valor
            //aumentar(numero); //debería cambiar, pero como es de tipo valor no se cambia
            aumentar(ref numero); //para que se comporte como tipo de referencia, se le agrega ref

            Console.WriteLine($"El número: {numero}"); // asi como está el valor no cambia, porque el valor no es por referencia, se envía una copia, no una referencia

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
        public string  Nombre{ get; set; }
        public decimal SalarioMensual { get; set; }
        public decimal SalarioAnual 
        { 
            get
            {
                return SalarioMensual * 12;
            }
        }

    }
}
