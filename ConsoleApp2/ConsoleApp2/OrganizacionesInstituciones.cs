using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class OrganizacionesInstituciones : Cliente
    {
        string licencia;

        public OrganizacionesInstituciones(string miNombre, double miRut, string miLicencia) : base(miNombre, miRut)
        {
            licencia = miLicencia;
        }
        public bool AceptarArriendo(OrganizacionesInstituciones organizacionesInstituciones)
        {
            if (licencia == "si")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
