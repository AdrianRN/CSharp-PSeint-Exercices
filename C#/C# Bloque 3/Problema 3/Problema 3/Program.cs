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
            //declarar variable inicial
            short shDato;

            //ingresar el numero de la variable
            Console.WriteLine("Ingrese un numero");
            shDato = short.Parse(Console.ReadLine());

            //proceso *conversiones
            int iDato = shDato;
            long loDato = shDato;
            float flDato = shDato;
            double doDato = shDato;
            decimal decDato = shDato;

            //salidas
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);



            Console.ReadKey();








        }
    }
}
