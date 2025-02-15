
using System;

namespace parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número:");
            int num2 = int.Parse(Console.ReadLine());

            bool esMayor = num1 > num2;
            bool esMenor = num1 < num2;
            bool esIgual = num1 == num2;

            Console.WriteLine($"¿El primer número es mayor que el segundo? {esMayor}");
            Console.WriteLine($"¿El primer número es menor que el segundo? {esMenor}");
            Console.WriteLine($"¿El primer número es igual al segundo? {esIgual}");

            bool andResultado = esMayor && esIgual;
            bool orResultado = esMayor || esIgual;

            Console.WriteLine($"¿El primer número es mayor y también igual al segundo? {andResultado}");
            Console.WriteLine($"¿El primer número es mayor o igual al segundo? {orResultado}");
        }
    }
}