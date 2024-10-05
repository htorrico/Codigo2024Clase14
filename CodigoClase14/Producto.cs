using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoClase14
{
    public class Producto
    {
        public string Nombre { get; set; }        
              
        public void GuardarProducto()
        {
            Console.WriteLine($"Producto {Nombre} guardado.");
        }
    
       
    }

}
