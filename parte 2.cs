
using System;

namespace parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número (entero):");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (entero):");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Suma : {num1} + {num2} = {num1 + num2}");
            Console.WriteLine($"Resta : {num1} - {num2} = {num1 - num2}");
            Console.WriteLine($"Multiplicación : {num1} * {num2} = {num1 * num2}");
            Console.WriteLine($"División (entero): {num1} / {num2} = {(num2 != 0 ? (num1 / num2).ToString() : "División por cero no permitida")}");

            Console.WriteLine("Ingrese el primer número (decimal):");
            decimal dec1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (decimal):");
            decimal dec2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (decimal): {dec1} + {dec2} = {dec1 + dec2}");
            Console.WriteLine($"Resta (decimal): {dec1} - {dec2} = {dec1 - dec2}");
            Console.WriteLine($"Multiplicación (decimal): {dec1} * {dec2} = {dec1 * dec2}");
            Console.WriteLine($"División (decimal): {dec1} / {dec2} = {(dec2 != 0 ? (dec1 / dec2).ToString() : "División por cero no permitida")}");

            Console.WriteLine("Ingrese el primer número (decimales):");
            float float1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (decimales):");
            float float2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (decimales): {float1} + {float2} = {float1 + float2}");
            Console.WriteLine($"Resta (decimales): {float1} - {float2} = {float1 - float2}");
            Console.WriteLine($"Multiplicación (decimales): {float1} * {float2} = {float1 * float2}");
            Console.WriteLine($"División (decimales): {float1} / {float2} = {(float2 != 0 ? (float1 / float2).ToString() : "División por cero no permitida")}");

            Console.WriteLine("Ingrese el primer número (Int16):");
            short short1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (Int16):");
            short short2 = short.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (Int16): {short1} + {short2} = {short1 + short2}");
            Console.WriteLine($"Resta (Int16): {short1} - {short2} = {short1 - short2}");
            Console.WriteLine($"Multiplicación (Int16): {short1} * {short2} = {short1 * short2}");
            Console.WriteLine($"División (Int16): {short1} / {short2} = {(short2 != 0 ? (short1 / short2).ToString() : "División por cero no permitida")}");

            Console.WriteLine("Ingrese el primer número (byte):");
            byte byte1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (byte):");
            byte byte2 = byte.Parse(Console.ReadLine());

            Console.WriteLine($"Suma (byte): {byte1} + {byte2} = {byte1 + byte2}");
            Console.WriteLine($"Resta (byte): {byte1} - {byte2} = {byte1 - byte2}");
            Console.WriteLine($"Multiplicación (byte): {byte1} * {byte2} = {byte1 * byte2}");
            Console.WriteLine($"División (byte): {byte1} / {byte2} = {(byte2 != 0 ? (byte1 / byte2).ToString() : "División por cero no permitida")}");
        }
    }
}