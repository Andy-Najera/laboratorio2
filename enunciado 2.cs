using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7:");
            int numero = int.Parse(Console.ReadLine());
            string dia;

            switch (numero)
            {
                case 1:
                    dia = "Lunes";
                    break;
                case 2:
                    dia = "Martes";
                    break;
                case 3:
                    dia = "Miércoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "Sábado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "Número inválido. Por favor ingrese un número del 1 al 7.";
                    break;
            }

            Console.WriteLine($"El día correspondiente es: {dia}");
        }
    }
}

//switch es más claro y conciso cuando se trata de comparar un valor específico contra múltiples casos posibles.
