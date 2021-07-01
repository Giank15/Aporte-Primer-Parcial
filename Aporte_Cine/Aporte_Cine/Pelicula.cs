using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_Cine
{
    public abstract class Pelicula
    {
        //Propiedades (Caracteristicas)
        public string NombrePelicula { get; set; }

        public virtual void MostrarPelicula()
        {
            Console.WriteLine("Pelicula: {0}", NombrePelicula);
        }
        public abstract void MostrarCliente();
        public abstract void MostrarSala();
    }
}
