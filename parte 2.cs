
using System;

namespace parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer n�mero (entero):");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero (entero):");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma : {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta : {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicaci�n : {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"Divisi�n (entero): {num1} / {num2} = {(num2 != 0 ? (num1 / num2).ToString() : "Divisi�n por cero no permitida")}");

            Console.WriteLine("Ingrese el primer n�mero (decimal):");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero (decimal):");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (decimal): {dec1} + {dec2} = {dec1 + dec2}");
            Console.WriteLine($"Resta (decimal): {dec1} - {dec2} = {dec1 - dec2}");
            Console.WriteLine($"Multiplicaci�n (decimal): {dec1} * {dec2} = {dec1 * dec2}");
            Console.WriteLine($"Divisi�n (decimal): {dec1} / {dec2} = {(dec2 != 0 ? (dec1 / dec2).ToString() : "Divisi�n por cero no permitida")}");

            Console.WriteLine("Ingrese el primer n�mero (decimales):");
            float float1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero (decimales):");
            float float2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (decimales): {float1} + {float2} = {float1 + float2}");
            Console.WriteLine($"Resta (decimales): {float1} - {float2} = {float1 - float2}");
            Console.WriteLine($"Multiplicaci�n (decimales): {float1} * {float2} = {float1 * float2}");
            Console.WriteLine($"Divisi�n (decimales): {float1} / {float2} = {(float2 != 0 ? (float1 / float2).ToString() : "Divisi�n por cero no permitida")}");

            Console.WriteLine("Ingrese el primer n�mero (Int16):");
            short short1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero (Int16):");
            short short2 = short.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (Int16): {short1} + {short2} = {short1 + short2}");
            Console.WriteLine($"Resta (Int16): {short1} - {short2} = {short1 - short2}");
            Console.WriteLine($"Multiplicaci�n (Int16): {short1} * {short2} = {short1 * short2}");
            Console.WriteLine($"Divisi�n (Int16): {short1} / {short2} = {(short2 != 0 ? (short1 / short2).ToString() : "Divisi�n por cero no permitida")}");

            Console.WriteLine("Ingrese el primer n�mero (byte):");
            byte byte1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo n�mero (byte):");
            byte byte2 = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (byte): {byte1} + {byte2} = {byte1 + byte2}");
            Console.WriteLine($"Resta (byte): {byte1} - {byte2} = {byte1 - byte2}");
            Console.WriteLine($"Multiplicaci�n (byte): {byte1} * {byte2} = {byte1 * byte2}");
            Console.WriteLine($"Divisi�n (byte): {byte1} / {byte2} = {(byte2 != 0 ? (byte1 / byte2).ToString() : "Divisi�n por cero no permitida")}");
        }
    }
}