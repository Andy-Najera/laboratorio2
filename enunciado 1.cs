
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la edad de la persona:");
            int edad = int.Parse(Console.ReadLine());
            string categoria;

            if (edad < 12)
            {
                categoria = "Niño";
            }
            else if (edad >= 12 && edad <= 17)
            {
                categoria = "Adolescente";
            }
            else if (edad >= 18 && edad <= 59)
            {
                categoria = "Adulto";
            }
            else if (edad >= 60 && edad <= 100)
            {
                categoria = "Adulto mayor";
            }
            else
            {
                categoria = "RIP";
            }

            Console.WriteLine($"La categoría de la persona es: {categoria}");
        }
    }
}

//if-else permite evaluar condiciones que involucran rangos de valores, lo cual es necesario para determinar la categoría de edad.