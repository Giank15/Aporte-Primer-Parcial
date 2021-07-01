using System;
using System.Collections.Generic;

namespace Aporte_Cine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Clientes del Día...");
            //Clientes
            Cliente cliente1 = new Cliente();
            cliente1.NombreCliente = "Juan Perez";
            cliente1.NombrePelicula = "El Conjuro 3";
            cliente1.Nsala = 3;
            cliente1.Asiento = "J11";
            cliente1.Suministros = "Gafas 3D";
            cliente1.Productos = "Bote de Palomitas Grande y Gaseosa Mediana";

            Cliente cliente2 = new Cliente();
            cliente2.NombreCliente = "Dereck Fisher";
            cliente2.NombrePelicula = "Luca";
            cliente2.Nsala = 5;
            cliente2.Asiento = "B4";
            cliente2.Suministros = "Poster Promocional";
            cliente2.Productos = "Hot-Dog y Gaseosa Grande";

            //Lista de Salas del Cine creados
            List<Pelicula> Lista = new List<Pelicula>();
            Lista.Add(cliente1);
            Lista.Add(cliente2);

            foreach (Pelicula pelicula in Lista)
            {
                pelicula.MostrarCliente();
                pelicula.MostrarPelicula();
                pelicula.MostrarSala();
                Console.WriteLine();
            }


        }
    }
}
