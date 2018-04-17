using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Cliente
    {
        List<Persona> listapersonas;
        List<Empresa> listaempresas;
        List<OrganizacionesInstituciones> listaorg;
        string nombre;
        double rut;

        public Cliente(string miNombre, double miRut)
        {
            nombre = miNombre;
            rut = miRut;
        }
        public bool AgregarPersona(Persona personas)
        {
           if (listapersonas.Contains(personas))
            {
                return false;
            }
            else
            {
                listapersonas.Add(personas);
                return true;
            }
        }
    }
}
