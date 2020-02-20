using System;

namespace Pilares_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            var vector1 = new Vector(new int[] { 1, 6 });
            var vector2 = new Vector(new int[] { 2, 5 });

            var vectorSuma = vector1 + vector2;

            Console.WriteLine("La suma es" + vectorSuma);
        }
    }

    public class Vector
    {
        public Vector( int[] valores)
        {
            vector = valores;
        }

        private int[] vector { get; set; }

        public int dimension {get { return vector.Length; } }
        
        public int this [int i]
        {
            get { return vector[i]; }
            set { vector[i] = value; }
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return Sumar(v1, v2); 
        }

        public static Vector Sumar(Vector vector1, Vector vector2) // regresa una instancia de Vector 
        {
            //sumar los vectores
            if (vector1.dimension != vector2.dimension)
            {
                throw new ApplicationException("No puedes sumar vectores de dimensiones distintas");
            }

            int[] resultado = new int[vector1.dimension];
            for (int i=0; i<vector1.dimension; i++)
            {
                resultado[i] = vector1[i] + vector2[i];
            }

            var vectorSuma = new Vector(resultado);

            return vectorSuma;
        }
    }
}
