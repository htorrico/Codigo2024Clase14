using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Rectangulo : IFigura
    {
        public int Base { get; set; }
        public int Altura { get; set; }

        public  int CalcularArea()
        {
            return Base * Altura;
        }

        public int CalcularPerimetro()
        {
            return (Base + Altura) * 2;
        }
    }
}
