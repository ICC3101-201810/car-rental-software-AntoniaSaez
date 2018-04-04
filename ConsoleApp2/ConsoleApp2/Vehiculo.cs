using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    class Vehiculo : Sucursal
    {
        string tipo;
        string patente

        public Vehiculo(string miNombre, string miDireccion, string miTipo, string miPatente) : base(miNombre, miDireccion)
        {
            tipo = miTipo;
            patente = miPatente;
        }
    }
}
