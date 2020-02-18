using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class RepositorioPersonasEnMemoria : IRepositorioPersonas, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void ObtenerPersonas()
        {
            Console.WriteLine("obteniendo personas en la memoria");
        }
    }
}
