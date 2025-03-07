using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        public enum menu { Agregar=1, Mostrar, Contar, Eliminar, Actualizar}
        static void Main(string[] args)
        {
            Acciones acciones = new Acciones();
            while (true) 
            {
                switch (Menu())
                {
                    case menu.Agregar:
                        acciones.AgregarAuto();
                        break;
                    case menu.Mostrar:
                        acciones.MostrarAutos();
                        break;
                    case menu.Contar:
                        Console.WriteLine($"Hay {acciones.ContarAutomoviles()} automoviles");
                        acciones.ContarAutomoviles();
                        break;
                    case menu.Eliminar:
                        Console.WriteLine("Marca que deseas eliminar: ");
                        string nombremarca = Console.ReadLine();
                        acciones.EliminarAutomoviles(nombremarca);
                        break;
                    case menu.Actualizar:
                        Console.WriteLine("Marca vieja: ");
                        string nombreMarca = Console.ReadLine();
                        Console.WriteLine("Marca nueva: ");
                        string nuevaMarca = Console.ReadLine();
                        Console.WriteLine("modelo nuevo: ");
                        string nuevoModelo = Console.ReadLine();
                        Console.WriteLine("año nuevo: ");
                        int nuevoAño = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Puertas nuevas: ");
                        int nuevoPuertas = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Nuevo color: ");
                        string nuevoColor = Console.ReadLine();
                        acciones.ActualizarAutomovil(nombreMarca, nuevaMarca, nuevoModelo, nuevoAño, nuevoPuertas, nuevoColor);
                        break;
                }
            }
        }
        static menu Menu()
        {
            Console.WriteLine("1) Agregar automovil");
            Console.WriteLine("2) Mostrar automovil");
            Console.WriteLine("3) Contar automovil");
            Console.WriteLine("4) Eliminar automovil");
            Console.WriteLine("5) Actualizar automovil");
            menu opc = (menu) Convert.ToInt32(Console.ReadLine());
            return opc;
        }
    }
}
