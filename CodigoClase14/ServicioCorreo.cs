using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class ServicioCorreo
    {

        public string EmailProveedor { get; set; }
        public string EmailAlmacen { get; set; }

        public void EnviarCorreoSobreStockBajo()
        {
       
         Console.WriteLine($"Enviando correo al proveedor {EmailProveedor} sobre stock bajo.");
     
        }

        public void EnviarCorreoSobreStockAlto()
        {

            Console.WriteLine($"Enviando correo al trabajador {EmailAlmacen} sobre stock alto.");

        }


    }
}
