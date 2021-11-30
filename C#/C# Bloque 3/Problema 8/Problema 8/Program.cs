using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float flDato;

            Console.WriteLine("Ingrese un numero");
            flDato = float.Parse(Console.ReadLine());

            double doDato = flDato;


            Console.WriteLine("double: {0}", doDato);


            Console.ReadKey();

        }
    }
}
