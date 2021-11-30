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
            sbyte sDato;

            Console.WriteLine("Ingrese un numero: ");
            sDato = sbyte.Parse(Console.ReadLine());

            short shDato = sDato;
            Console.WriteLine("short: {0}", shDato);

            int iDato = sDato;
            Console.WriteLine("int: {0}", iDato);

            long loDato = sDato;
            Console.WriteLine("long: {0}", loDato);

            float flDato = sDato;
            Console.WriteLine("long: {0}", flDato);

            double doDato = sDato;
            Console.WriteLine("double: {0}", doDato);

            decimal deDato = sDato;
            Console.WriteLine("decimal {0}", deDato);



            Console.ReadKey();


        }
    }
}
