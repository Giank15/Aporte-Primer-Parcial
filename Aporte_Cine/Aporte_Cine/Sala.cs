using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_Cine
{
    public abstract class Sala : Pelicula
    {
        //Propiedades (Caracteristicas)
        public int Nsala { get; set; }
        public string Asiento { get; set; }
        public string Suministros { get; set; }

        public override void MostrarSala()
        {
            Console.WriteLine("Sala: {0} \nAsiento: {1} \nSuministros: {2}", Nsala, Asiento, Suministros);
        }
        
    }
}
