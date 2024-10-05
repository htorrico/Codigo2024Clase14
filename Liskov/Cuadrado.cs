using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    public class Cuadrado : IFigura
    {
        public int Lado { get; set; }

        public int CalcularArea()
        {
            return Lado * Lado;
        }

        public int CalcularPerimetro()
        {
            return Lado * 4;
        }
    }
}
