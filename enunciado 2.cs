using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un n�mero del 1 al 7:");
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
                    dia = "Mi�rcoles";
                    break;
                case 4:
                    dia = "Jueves";
                    break;
                case 5:
                    dia = "Viernes";
                    break;
                case 6:
                    dia = "S�bado";
                    break;
                case 7:
                    dia = "Domingo";
                    break;
                default:
                    dia = "N�mero inv�lido. Por favor ingrese un n�mero del 1 al 7.";
                    break;
            }

            Console.WriteLine($"El d�a correspondiente es: {dia}");
        }
    }
}

//switch es m�s claro y conciso cuando se trata de comparar un valor espec�fico contra m�ltiples casos posibles.
