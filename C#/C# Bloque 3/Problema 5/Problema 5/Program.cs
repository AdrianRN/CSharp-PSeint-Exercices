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
            int iDato;

            Console.WriteLine("Ingrese un numero");
            iDato = int.Parse(Console.ReadLine());


            long loDato = iDato;
            float flDato = iDato;
            double doDato = iDato;
            decimal decDato = iDato;


            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);

            Console.ReadKey();



        }
    }
}
