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
                Console.WriteLine("Desea recibir un vehiculo a la sucursal: si o no");
                var respuestaagregarvehiculo = Console.ReadLine();
                while (respuestaagregarvehiculo == "si")
                {
                    Console.WriteLine("Agregar un vehiculo a la sucursal");
                    Console.WriteLine("Su vehiculo es un: auto, acuático, moto, camión, bus y maquinaria pesada");
                    var tipo = Console.ReadLine();
                    Console.WriteLine("Escriba la patente de su vehiculo");
                    var patente = Console.ReadLine();
                    Vehiculo vehiculo1 = new Vehiculo(tipo, patente);
                    if (sucursal1.AgregarVehiculo(vehiculo1))
                    {
                        Console.WriteLine("vehiculo agregado con exito");
                    }
                    else
                    {
                        Console.WriteLine("no se pudo agregar su vehiculo");
                    }

                }
                

            }
            else
            {
                Console.WriteLine("Desea arrendar un vehiculo: si o no");
                var respuestaarriendo = Console.ReadLine();
                while (respuestaarriendo == "si")
                {
                    Console.WriteLine("Escriba su nombre ");
                    var nombre = Console.ReadLine();
                    Console.WriteLine("Escriba su rut sin punto ni guion (Ej: 123456789");
                    int rut;
                    rut = int.Parse(Console.ReadLine());
                    Cliente cliente1 = new Cliente(nombre, rut);
                    Console.WriteLine("Es una persona, empresa u organizacioninstitucional?");
                    var respuestatipocliente = Console.ReadLine();
                    if (respuestatipocliente == "persona")
                    {
                        Console.WriteLine("Tiene licencia para manejar?");
                        var licencia = Console.ReadLine();
                        Persona persona1 = new Persona(nombre, rut, licencia);
                        if (cliente1.AgregarPersona(persona1))
                        {
                            Console.WriteLine("Ya se ha registrado");
                            
                            

                        }
                        else
                        {
                            Console.WriteLine("Ya se habia registrado antes");
                        }


                    }
                    if (respuestatipocliente == "empresa")
                    {
                        Console.WriteLine("Tiene licencia para manejar?");
                        var licencia = Console.ReadLine();
                        Empresa empresa1 = new Empresa(nombre, rut, licencia);
                        if (cliente1.AgregarEmpresa(empresa1))
                        {
                            Console.WriteLine("Ya se ha registrado");
                        }
                        else
                        {
                            Console.WriteLine("Ya se habia registrado antes");
                        }

                    }

                    if (respuestatipocliente == "organizacioninstitucional")
                    {
                        Console.WriteLine("Tiene licencia para manejar?");
                        var licencia = Console.ReadLine();
                        OrganizacionesInstituciones organizacionesInstituciones1 = new OrganizacionesInstituciones(nombre, rut, licencia);
                        if (cliente1.AgregarOrgaoinstitucion(organizacionesInstituciones1))
                        {
                            Console.WriteLine("Ya se ha registrado");
                        }
                        else
                        {
                            Console.WriteLine("Ya se habia registrado antes");
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }

                    
                }

                

            }

            

        }
    }
}
