using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Acciones
    {
        public List<Automovil> listaautomoviles = new List<Automovil>();
        Automovil a = new Automovil();

        public void AgregarAuto()
        {
            Console.WriteLine("Marca:");
            a.Marca = Console.ReadLine();
            Console.WriteLine("Modelo:");
            a.Modelo = Console.ReadLine();
            Console.WriteLine("Año:");
            a.Año = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Numero de puertas:");
            a.NoPuertas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Color:");
            a.Color = Console.ReadLine();

            listaautomoviles.Add(new Automovil(a.Marca,a.Modelo,a.Año,a.NoPuertas,a.Color));
        }
        public void MostrarAutos()
        { 
            foreach (var a in listaautomoviles)
            {
                Console.WriteLine($"Marca: {a.Marca}");
                Console.WriteLine($"Modelo: {a.Modelo}");
                Console.WriteLine($"Año: {a.Año}");
                Console.WriteLine($"Numero de puertas: {a.NoPuertas}");
                Console.WriteLine($"Color: {a.Color}");
            }
        }
        public int ContarAutomoviles()
        {
            return listaautomoviles.Count;
        }
        public void EliminarAutomoviles(string nombremarca)
        {
            var automovil = listaautomoviles.Find(x => x.Marca == nombremarca);
            if (automovil != null)
                listaautomoviles.Remove(automovil);
            else
                Console.WriteLine("No se encuentra automovil");
        }
        // Blep
        public void ActualizarAutomovil(string nombreMarca, string nuevaMarca, string nuevoModelo, int nuevoAño, int nuevoPuertas, string nuevoColor)
        {
            var automovil = listaautomoviles.Find(x => x.Marca == nombreMarca);
            if (automovil != null)
            {
                automovil.Marca = nuevaMarca;
                automovil.Modelo = nuevoModelo;
                automovil.Año = nuevoAño;
                automovil.NoPuertas = nuevoPuertas;
                automovil.Color = nuevoColor;
            }
            else
            {
                Console.WriteLine("No se encuentra el automóvil");
            }
        }
    }
}
