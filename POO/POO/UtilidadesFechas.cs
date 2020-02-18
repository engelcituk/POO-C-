using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public static class UtilidadesFechas // clase statica
    {
        public static int CalcularEdad(this DateTime fechaNacimiento) // por eso sus metodos tienen que ser staticos,
            // si se le agrega el this se vuelve un metodo de extension
        {
            var edad = DateTime.Today.Year - fechaNacimiento.Year;
            var temp = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);

            if (temp > DateTime.Today)
            {
                edad--;
            }
            return edad;
        }
    }

    public static class UtilidadesStrings // clase statica
    {
        public static int ContarVocales(this string valor) // por eso sus metodos tienen que ser staticos,
                                                                      // si se le agrega el this se vuelve un metodo de extension
        {
            
            if (valor == null)
            {
                throw new ArgumentException("El parametro no puede ser nulo");
            }
            var resultado = 0;
            var vocales = "aeiou";
            valor = valor.ToLower();

            foreach (var caracter in valor)
            {
                if (vocales.Contains(caracter))
                {
                    resultado++;
                }
            }
            return resultado;
            
        }
    }
}
