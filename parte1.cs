using System;

namespace parte1 
{
	class Program
	{
		static void Main(string[] args)
		{
			int numeroEntero;
			double numeroDecimal;
			string texto;
			bool valorBooleano;

			Console.Write("Introduce un n�mero entero: ");
			numeroEntero = int.Parse(Console.ReadLine());

			Console.Write("Introduce un n�mero decimal: ");
			numeroDecimal = double.Parse(Console.ReadLine());

			Console.Write("Introduce un texto: ");
			texto = Console.ReadLine();

			Console.Write("Introduce un valor verdadero o falso (true/false): ");
			valorBooleano = bool.Parse(Console.ReadLine());

			Console.WriteLine("N�mero entero: " + numeroEntero);
			Console.WriteLine("N�mero decimal: " + numeroDecimal);
			Console.WriteLine("Texto: " + texto);
			Console.WriteLine("Valor booleano: " + valorBooleano);
		}
	}
}
