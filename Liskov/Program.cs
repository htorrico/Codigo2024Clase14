using Liskov;

List<IFigura> figuras = new List<IFigura>();

IFigura rectangulo = new Rectangulo
{
    Altura = 20,
    Base = 30
};

IFigura cuadrado = new Cuadrado
{
    Lado = 10
};

figuras.Add(cuadrado);
figuras.Add(rectangulo);


foreach (var item in figuras)
{
Console.WriteLine( item.CalcularArea());
}


Console.Read();


