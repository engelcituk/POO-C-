using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public static class UtilidadesFechas // clase statica
    {
        public static int CalcularEdad(DateTime fechaNacimiento) // por eso sus metodos tienen que ser staticos
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
}
