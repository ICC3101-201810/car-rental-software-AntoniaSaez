using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido");
            Console.WriteLine("Desea crear su propia sucursal, si o no?");
            var respuestasucursal = Console.ReadLine();
            if (respuestasucursal == "si")
            {
                Console.WriteLine("Cual es el nombre de su sucursal?");
                var nombre = Console.ReadLine();
                Console.WriteLine("Escriba la direccion de su sucursal");
                var direccion = Console.ReadLine();
                Console.WriteLine("Cuantos vehiculos tiene su sucursal?");
                int cantvehiculos;
                cantvehiculos = int.Parse(Console.ReadLine());
                Sucursal sucursal1 = new Sucursal(nombre, direccion, cantvehiculos);
                Console.WriteLine("Desea agregar un vehiculo a la sucursal");
                var respuestaagregarvehiculo = Console.ReadLine();
                while (respuestaagregarvehiculo == "si")
                {
                    Console.WriteLine("Agregar un vehiculo a la sucursal");
                    Console.WriteLine("Su vehiculo es un: auto, acuático, moto, camión, bus y maquinaria pesada");
                    var tipo = Console.ReadLine();
                    Console.WriteLine("Escriba la patente de su vehiculo");
                    var patente = Console.ReadLine();
                    Vehiculo vehiculo1 = new Vehiculo(tipo, patente);
                    sucursal1.AgregarVehiculo(vehiculo1);
                }              

            }
            else
            {
                Console.WriteLine("Desea arrendar un vehiculo: si o no");
                var respuestaarriendo = Console.ReadLine();
                while (respuestaarriendo == "si")
                {
                    Console.WriteLine("Que vehiculo desea arrendar?: auto, acuático, moto, camión, bus y maquinaria pesada ");
                    var tipo = Console.ReadLine();
                    
                }
                

            }

            

        }
    }
}
