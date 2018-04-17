using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Vehiculo 
    {
        Accesorio[] accesorios;
        string tipo;
        string patente;
        

        public Vehiculo(string miTipo, string miPatente)
        {
            tipo = miTipo;
            patente = miPatente;
        }
        
               
        public Accesorio[] GetListaAccesoriosDeseados()
        {
            return accesorios;
        }
    }
}
