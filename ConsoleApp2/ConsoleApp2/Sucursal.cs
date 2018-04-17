using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Sucursal
    {
        Vehiculo[] vehiculos;
        int cantvehiculos;
        string nombre;
        string direccion;
        List<Arrendar> listaarriendos = new List<Arrendar>();

        public Sucursal(string miNombre, string miDireccion, int micantidadvehiculos)
        {
            nombre = miNombre;
            direccion = miDireccion;
            vehiculos = new Vehiculo[cantvehiculos];
            cantvehiculos = micantidadvehiculos;
            ;
        }
        public bool AgregarVehiculo(Vehiculo vehiculo)
        {
            int i = cantvehiculos;
            if (cantvehiculos > 0)
            {
                int posicionvehiculo = cantvehiculos - vehiculos.Length;
                vehiculos[posicionvehiculo] = vehiculo;
                cantvehiculos--;
                return true;
            }

            else return false;
                   
        }
        public Vehiculo[] GetlistaVehiculos()
        {
            return vehiculos;
        }

        public void RegistrarArriendo(Arrendar arriendos)
        {
            listaarriendos.Add(arriendos);

        }
        
        
    }
}
