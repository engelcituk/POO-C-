using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class RepositorioPersonasDB : IRepositorioPersonas, IDisposable //se puede implemtar varias interfaces en una clase
    {
        public void Dispose() //libera recursos de una clase
        {
            throw new NotImplementedException();
        }

        public void ObtenerPersonas()
        {
            Console.WriteLine("obteniendo personas de la base de datos");
        }
    }
}
