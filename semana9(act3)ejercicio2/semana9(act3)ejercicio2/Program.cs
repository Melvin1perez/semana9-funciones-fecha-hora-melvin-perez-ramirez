//funciones de fecha hora melvin perez ejercicio 2
// Datos del préstamo
double montoPrestamo = 3000;
int plazoMeses = 6;
DateTime fechaPago = DateTime.Today;

// Calcular e imprimir las fechas de pago y las cuotas
Console.WriteLine("Fechas de pago y cuotas del préstamo:");
double cuotaMensual = montoPrestamo / plazoMeses;
for (int i = 0; i < plazoMeses; i++)
{
    fechaPago = fechaPago.AddMonths(1);
    Console.WriteLine($"Fecha de pago: {fechaPago:dd/MM/yyyy}, Cuota a pagar: ${cuotaMensual:F2}");
}