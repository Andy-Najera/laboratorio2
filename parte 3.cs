
using System;

namespace parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer n�mero:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero:");
            int num2 = int.Parse(Console.ReadLine());

            bool esMayor = num1 > num2;
            bool esMenor = num1 < num2;
            bool esIgual = num1 == num2;

            Console.WriteLine($"�El primer n�mero es mayor que el segundo? {esMayor}");
            Console.WriteLine($"�El primer n�mero es menor que el segundo? {esMenor}");
            Console.WriteLine($"�El primer n�mero es igual al segundo? {esIgual}");

            bool andResultado = esMayor && esIgual;
            bool orResultado = esMayor || esIgual;

            Console.WriteLine($"�El primer n�mero es mayor y tambi�n igual al segundo? {andResultado}");
            Console.WriteLine($"�El primer n�mero es mayor o igual al segundo? {orResultado}");
        }
    }
}