using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class EmpleadoJunior : Empleado
    {
        public override decimal CalcularBonificacion()
        {
            return SueldoBase * 0.1M;
        }
    }
}
