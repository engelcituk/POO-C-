using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DateTime dt = DateTime.Now; // Or whatever
            string s = dt.ToString("yyyyMMddHHmmss");
            var persona = new Persona();
            persona.FechaCreacion = dt; //instancio persona, pero heredo las propiedades de  Entidad
            Console.WriteLine($"La fecha de creación es {persona.FechaCreacion}");

        }
    }

    public class Entidad
    {
        public int Id { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }
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
}
