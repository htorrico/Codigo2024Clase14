using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ReservaHotel
    {
        public string NombreCliente { get; set; }       
        public DateTime FechaReserva { get; set; }

        public void HacerReserva()
        {
            Console.WriteLine($"Reserva hecha para {NombreCliente} el {FechaReserva}.");
        }            

    }
}
