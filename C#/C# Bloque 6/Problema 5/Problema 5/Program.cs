using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double num1, num2, VA1, VA2, pot1, pot2, RC1, RC2, seno1, seno2, coseno1, coseno2, numMax, numMin, pE1, pE2, redond1, redond2;

            //entradas
            Console.WriteLine("Ingrese el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("\n\n");

            //procesos num 1 y 2 respectivamente
            VA1 = Math.Abs(num1);
            VA2 = Math.Abs(num2);
            pot1 = Math.Pow(num1, num2);
            pot2 = Math.Pow(num2, num1);
            RC1 = Math.Sqrt(num1);
            RC2 = Math.Sqrt(num2);
            seno1 = Math.Sin(num1);
            seno2 = Math.Sin(num2);
            coseno1 = Math.Cos(num1);
            coseno2 = Math.Cos(num2);
            numMax = Math.Max(num1, num2);
            numMin = Math.Min(num1, num2);
            pE1 = Math.Truncate(num1);
            pE2 = Math.Truncate(num2);
            redond1 = Math.Round(num1);
            redond2 = Math.Round(num2);

            //salidas del numero 1
            Console.WriteLine("NUMERO 1: \n");
            Console.WriteLine("Numero 1. Valor Absoluto: " + VA1);
            Console.WriteLine("Numero 1. Potencia: " + pot1);
            Console.WriteLine("Numero 1. Raíz cuadrada: " + RC1);
            Console.WriteLine("Numero 1. Seno: " + seno1);
            Console.WriteLine("Numero 1. Coseno: " + coseno1);
            Console.WriteLine("Numero 1. Parte Entera: " + pE1);
            Console.WriteLine("Numero 1. Redondeo:" + redond1);

            //salidas del numero 2
            Console.WriteLine("\n");
            Console.WriteLine("NUMERO 2: \n");
            Console.WriteLine("Numero 2. Valor Absoluto: " + VA2);
            Console.WriteLine("Numero 2. Potencia: " + pot2);
            Console.WriteLine("Numero 2. Raíz cuadrada: " + RC2);
            Console.WriteLine("Numero 2. Seno: " + seno2);
            Console.WriteLine("Numero 2. Coseno: " + coseno2);
            Console.WriteLine("Numero 2. Parte Entera: " + pE2);
            Console.WriteLine("Numero 2. Redondeo: " + redond2);

            Console.WriteLine("Numero máximo: " + numMax);
            Console.WriteLine("Numero mínimo: " + numMin);

            Console.ReadKey();
        }
    }
}
