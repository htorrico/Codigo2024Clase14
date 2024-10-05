using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class GestorStock
    {
        public int Stock { get; set; }
        public ServicioCorreo ServicioCorreo { get; set; }

        public void DiminuirStock(int cantidad)
        {
            Stock -= cantidad;
            Console.WriteLine($"Stock actualizado. Nuevo stock: {Stock}");

            if (Stock < 10)
            {                
                 ServicioCorreo.EnviarCorreoSobreStockBajo();
            }

        }

        public void AumentarStock(int cantidad)
        {
            Stock += cantidad;
            Console.WriteLine($"Stock actualizado. Nuevo stock: {Stock}");

            if (Stock > 100)
            {                
                ServicioCorreo.EnviarCorreoSobreStockAlto();
            }

        }


    }
}
