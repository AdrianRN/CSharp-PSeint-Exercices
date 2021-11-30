using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long loDato;

            Console.WriteLine("Ingrese un numero");
            loDato = long.Parse(Console.ReadLine());

            float flDato = loDato;
            double doDato = loDato;
            decimal decDato = loDato;


            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);


            Console.ReadKey();


        }
    }
}
