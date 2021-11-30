using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_7
{
    class Program
    {
        static void Main(string[] args)
        {
            char chDato;

            Console.WriteLine("Ingrese caracter");
            chDato = char.Parse(Console.ReadLine());

            ushort ushDato = chDato;
            int iDato = chDato;
            uint uiDato = chDato;
            long loDato = chDato;
            ulong uloDato = chDato;
            float flDato = chDato;
            double doDato = chDato;
            decimal decDato = chDato;


            Console.WriteLine("ushort: {}0", ushDato);
            Console.WriteLine("int: {}0", iDato);
            Console.WriteLine("uint: {}0", uiDato);
            Console.WriteLine("long: {}0", loDato);
            Console.WriteLine("ulong: {}0", uloDato);
            Console.WriteLine("float: {}0", flDato);
            Console.WriteLine("double: {}0", doDato);
            Console.WriteLine("decimal: {}0", decDato);




            Console.ReadKey();


        }
    }
}
