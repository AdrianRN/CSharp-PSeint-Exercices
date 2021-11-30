using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declar el valor inicial y que a partir de este vamos a convertir a todos los demas
            byte byDato;
            
            //entrada
            Console.WriteLine("Ingrese un numero:");
            byDato = byte.Parse(Console.ReadLine());

            //procesos (Conversiones que se realizan)
            short shDato = byDato;
            ushort ushDato = byDato;
            int iDato = byDato;
            uint uiDato = byDato;
            long loDato = byDato;
            ulong uloDato = byDato;
            float flDato = byDato;
            double doDato = byDato;
            decimal decDato = byDato;

            //salidas (Mostrar las conversiones hechas a su respectivo tipo de dato)
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("ulong: {0}", uloDato);
            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("double: {0}", doDato);
            Console.WriteLine("decimal: {0}", decDato);



            Console.ReadKey();




        }
    }
}
