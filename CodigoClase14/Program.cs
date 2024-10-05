
using CodigoClase14;

void Ejemplo01()
{
    Alimento alimento = new Alimento();
    alimento.ActualizarPrecio(10);
    alimento.ActualizarPrecio(20);


    Alerta alerta = new Alerta();
    alerta.EnviarCorreo();
    alerta.EnviarNotificacion();
}


void Ejemplo02()
{

    GestorStock gestorStock = new GestorStock
    {
        Stock = 50,
        ServicioCorreo = new ServicioCorreo
        {
            EmailAlmacen = "torricomarquezh@gmail.com",
            EmailProveedor = "torricomarquezh@gmail.com"
        }
    };
    gestorStock.DiminuirStock(30);
    gestorStock.DiminuirStock(15);
    gestorStock.AumentarStock(30);
    gestorStock.AumentarStock(40);
    gestorStock.AumentarStock(20);
    gestorStock.AumentarStock(10);

}


GestorHotel gestorHotel = new GestorHotel(
    
    new ReservaHotel { FechaReserva=DateTime.Now, NombreCliente="Hugo Torrico"},
    new ServicioCorreoHotel(),
    new ServicioReporte()
    
    );

gestorHotel.ProcesarReserva("htorrico@tecsup.edu.pe");


Console.Read();