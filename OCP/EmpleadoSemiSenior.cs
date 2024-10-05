using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class EmpleadoSemiSenior : Empleado
    {
        public override decimal CalcularBonificacion()
        {
            try
            {
                throw new Exception("Error Prueba");

                return SueldoBase * 0.2M;
            }
            catch (Exception)
            {
                Console.WriteLine("Error Comunicarse con el administrador");
                return 0;
            }
           
        }
    }
}
