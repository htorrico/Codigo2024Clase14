using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liskov
{
    //Liskov: El uso correcto de las interfaces
    public interface IAve
    {
        void Comer();
    }

    public interface IAveVoladora : IAve
    {
        void Volar();
    }

    public interface IAveNadadora : IAve
    {
        void Nadar();
    }

    public class Aguila : IAveVoladora
    {
        public void Comer()
        {
            Console.WriteLine("El águila está comiendo.");
        }

        public void Volar()
        {
            Console.WriteLine("El águila está volando.");
        }
    }

    public class Pinguino : IAveNadadora
    {
        public void Comer()
        {
            Console.WriteLine("El pingüino está comiendo.");
        }

        public void Nadar()
        {
            Console.WriteLine("El pingüino está nadando.");
        }
    }

}
