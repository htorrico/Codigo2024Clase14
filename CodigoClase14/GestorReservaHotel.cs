using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class GestorHotel
    {
        //Declaración privada
        private ReservaHotel _reservaHotel;
        private ServicioCorreoHotel _servicioCorreoHotel;
        private ServicioReporte _servicioReporte;

        //Inyectar los objetos por constructor
        public GestorHotel(ReservaHotel reservaHotel, 
                           ServicioCorreoHotel servicioCorreoHotel ,
                           ServicioReporte servicioReporte )
        {
            _reservaHotel = reservaHotel;
            _servicioCorreoHotel = servicioCorreoHotel;
            _servicioReporte = servicioReporte;
        }

        public void ProcesarReserva(string email)
        {            
            _reservaHotel.HacerReserva();
            _servicioCorreoHotel.EnviarConfirmacion(email);
            _servicioReporte.GenerarReporteReservas();
            
        }
    }
}
