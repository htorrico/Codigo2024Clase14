using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ServicioCorreoHotel
    {
        public void EnviarConfirmacion(string email)
        {
            Console.WriteLine($"Enviando confirmación a {email}...");
        }
        public void EnviarCancelacion(string email)
        {
            Console.WriteLine($"Enviando cancelacion a {email}...");
        }
    }
}
