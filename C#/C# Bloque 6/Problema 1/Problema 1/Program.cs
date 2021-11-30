using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, res, mult, div;
            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine()); //se convierte a int
            Console.WriteLine("Ingrese el segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine()); //se convierte a int

            //Procesos
            sum = num1 + num2;
            res = num1 - num2;
            mult = num1 * num2;
            div = num1 / num2;

            //Mostrar datos
            Console.WriteLine("El resultado de la suma es: " + sum);
            Console.WriteLine("El resultado de la resta es: " + res);
            Console.WriteLine("El resultado de la multiplicacion es: " + res);
            Console.WriteLine("El resultado de la division es: " + div);

            Console.ReadKey();

        }
    }
}
