

using OCP;

void EjemploSinOCP()
{
    EmpleadoSinOCP calculadorBonificacion = new EmpleadoSinOCP();
    Console.WriteLine(calculadorBonificacion.CalcularBonificacion("Junior", 4000));
    Console.WriteLine(calculadorBonificacion.CalcularBonificacion("Senior", 8000));
    Console.WriteLine(calculadorBonificacion.CalcularBonificacion("SemiSenior", 6000));
}

void EjmploConOCP()
{
    Empleado empleadoJunior = new EmpleadoJunior { SueldoBase = 4000, Nombre = "Hugo" };
    Empleado empleadoSenior = new EmpleadoSenior { SueldoBase = 8000, Nombre = "Juan" };
    Empleado empleadoSemiSenior = new EmpleadoSemiSenior { SueldoBase = 6000, Nombre = "José" };

    List<Empleado> empleados = new List<Empleado>();
    empleados.Add(empleadoJunior);
    empleados.Add(empleadoSenior);
    empleados.Add(empleadoSemiSenior);

    foreach (var item in empleados)
    {
        Console.WriteLine(item.CalcularBonificacion());
    }

}



Console.Read();


