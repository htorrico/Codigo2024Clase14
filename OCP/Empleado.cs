using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public  abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal SueldoBase { get; set; }


        public void MostrarInformacion()
        {
            Console.WriteLine(Nombre);
            Console.WriteLine(SueldoBase);
        }

        public  abstract decimal CalcularBonificacion();

    }
}
