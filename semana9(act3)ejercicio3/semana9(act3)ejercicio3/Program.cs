//funciones de fecha y hora ejercicio 3 melvin perez ramirez
Console.Write("Ingrese su próxima fecha de cumpleaños en numeros desde el año hasta el dia separados por un guion (YYYY-MM-DD): ");
string inputFechaCumpleanos = Console.ReadLine();

if (DateTime.TryParse(inputFechaCumpleanos, out DateTime fechaCumpleanos))
{
    TimeSpan tiempoRestante = fechaCumpleanos - DateTime.Today;
    int diasRestantes = tiempoRestante.Days;

    Console.WriteLine($"Fecha de cumpleaños ingresada: {fechaCumpleanos.ToShortDateString()}");
    Console.WriteLine($"Días restantes hasta el cumpleaños: {diasRestantes} días");
}
