using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Arrendar
    {
        Cliente[] clientes;
        Vehiculo[] vehiculos;
        Accesorio[] accesorios;

        public  Arrendar(Accesorio[] misaccesorios, Cliente[] misclientes, Vehiculo[] misvehiculos)
        {
            vehiculos = misvehiculos;
            accesorios = misaccesorios;
            clientes = misclientes;
        }

        
    }
}
