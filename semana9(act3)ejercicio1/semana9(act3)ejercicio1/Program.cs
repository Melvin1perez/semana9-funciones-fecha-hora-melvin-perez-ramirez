//funciones de fecha y hora ejercicio 1 melvin perez
int[] years = new int[9] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };

Console.WriteLine("Años y su estado (bisiesto o no):");

foreach (int year in years)
{
    bool esBisiesto = DateTime.IsLeapYear(year);
    string estado = esBisiesto ? "Bisiesto" : "No bisiesto";
    Console.WriteLine($"{year}: {estado}");
}
