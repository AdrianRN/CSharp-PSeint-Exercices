using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int r1, r2, r3, r4, r5, numerador1, numerador2, numerador3, numerador4, numerador5, denominador1, denominador2, denominador3, denominador4, denominador5;
            //Entradas de datos

            //Numeradores
            Console.WriteLine("Ingresa el primer numerador: ");
            numerador1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo numerador: ");
            numerador2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer numerador: ");
            numerador3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cuarto numerador: ");
            numerador4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el quinto numerador: ");
            numerador5 = int.Parse(Console.ReadLine());


            //denominadores
            Console.WriteLine("Ingresa el primer denominador: ");
            denominador1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el segundo denominador: ");
            denominador2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el tercer denominador: ");
            denominador3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el cuarto denominador: ");
            denominador4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el quinto denominador: ");
            denominador5 = int.Parse(Console.ReadLine());
            //Procesos
            r1 = numerador1 % denominador1;
            r2 = numerador2 % denominador2;
            r3 = numerador3 % denominador3;
            r4 = numerador4 % denominador4;
            r5 = numerador5 % denominador5;



            //Salida de datos

            Console.WriteLine("El residuo de la division 1 es: " + r1);
            Console.WriteLine("El residuo de la division 2 es: " + r2);
            Console.WriteLine("El residuo de la division 3 es: " + r3);
            Console.WriteLine("El residuo de la division 4 es: " + r4);
            Console.WriteLine("El residuo de la division 5 es: " + r5);



            Console.ReadKey();
        }
    }
}
