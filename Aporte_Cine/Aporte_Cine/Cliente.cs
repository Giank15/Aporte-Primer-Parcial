using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte_Cine
{
    public class Cliente : Sala
    {
        public string NombreCliente { get; set; }
        public string Productos { get; set; }

        public override void MostrarCliente()
        {
            Console.WriteLine("Nombre de Cliente: {0} \nProductos: {1}", NombreCliente, Productos);
        }
    }
}
