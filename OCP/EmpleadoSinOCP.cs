using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class EmpleadoSinOCP
    {
        public decimal CalcularBonificacion(string tipoEmpleado,decimal sueldoBase)
        {
            try
            {
                decimal bonificacion = 0;
                throw new Exception("Error Prueba");
                if (tipoEmpleado == "SemiSenior")
                {                    
                    bonificacion = sueldoBase * 0.2M;
                }
                if (tipoEmpleado == "Junior")
                {
                    bonificacion = sueldoBase * 0.1M;
                }
                if (tipoEmpleado == "Senior")
                {
                    bonificacion = sueldoBase * 0.3M;
                }               
                return bonificacion;
            }
            catch (Exception)
            {

                Console.WriteLine("Error comunicarse con el administrador");
                return 0;
            }
           

        }
    }
}
