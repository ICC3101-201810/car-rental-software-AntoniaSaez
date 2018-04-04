using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Arrendar
    {
        List<Cliente> cliente = new List<Cliente>();
        List<Sucursal> sucursal = new List<Sucursal>();
        List<Vehiculo> vehiculo = new List<Vehiculo>();
        List<Accesorio> accesorio = new List<Accesorio>();
        DateTime fechaInicio;
        DateTime fechaTermino;

        public Arrendar(List<Cliente> micliente, List<Sucursal> misucursal, List<Vehiculo> mivehiculo, List<Accesorio> miaccesorio, DateTime mifechaInicio, DateTime mifechaTermino)
        {
            cliente = micliente;
            vehiculo = mivehiculo;
            accesorio = miaccesorio;
            fechaInicio = mifechaInicio;
            fechaTermino = mifechaTermino;

        }

        public void RegistroCliente(List<Cliente> cliente1)
        {
            cliente1.Add(cliente);   
        }
        public void RegistroSucursal(List<Sucursal> sucursal1)
        {
            sucursal1.Add();
        }

    }
}
