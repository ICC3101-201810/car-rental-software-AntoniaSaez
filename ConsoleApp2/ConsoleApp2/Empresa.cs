using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3
{
    public class Empresa : Cliente
    {
        string licencia;

        public Empresa(string miNombre, double miRut, string miLicencia) : base(miNombre, miRut)
        {
            licencia = miLicencia;
        }
        public bool AgregarEmpresa(Empresa empresa)
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
