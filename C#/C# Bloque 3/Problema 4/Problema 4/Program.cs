using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort ushDato;

            Console.WriteLine("Ingrese un numero");
            ushDato = ushort.Parse(Console.ReadLine());

            int iDato = ushDato;
            long loDato = ushDato;
            float flDato = ushDato;
            double doDato = ushDato;
            decimal decDato = ushDato;

            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);

            Console.ReadKey();


        }
    }
}
