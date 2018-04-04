using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Persona : Cliente
    {
        string licencia;

        public Persona(string miNombre, double miRut, string miLicencia) : base(miNombre, miRut)
        {
            licencia = miLicencia;
        }
        public bool AgregarPersona(Persona persona)
        {
            if (licencia =="si")
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
