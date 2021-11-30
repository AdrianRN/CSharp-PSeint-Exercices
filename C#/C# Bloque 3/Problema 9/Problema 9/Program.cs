using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong uloDato;
            
            Console.WriteLine("Ingrese un numero");
            uloDato = ulong.Parse(Console.ReadLine());

            float flDato = uloDato;
            double doDato = uloDato;
            decimal decDato = uloDato;


            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);

            Console.ReadKey();

        }
    }
}
