using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double douDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            int iDato;
            uint uiDato;
            long loDato;
            ulong uloDato;
            char chDato;
            float flDato;
            decimal decDato;

            //entrada
            Console.WriteLine("Ingrese un numero");
            douDato = double.Parse(Console.ReadLine());

            //procesos, conversiones de dato
            sbyDato = (sbyte)douDato;
            byDato = (byte)douDato;
            shDato = (short)douDato;
            ushDato = (ushort)douDato;
            iDato = (int)douDato;
            uiDato = (uint)douDato;
            loDato = (long)douDato;
            uloDato = (ulong)douDato;
            chDato = (char)douDato;
            flDato = (float)douDato;
            decDato = (decimal)douDato;

            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("ulong: {0}", uloDato);
            Console.WriteLine("char: {0}", chDato);
            Console.WriteLine("float: {0}", flDato);
            Console.WriteLine("decimal: {0}", decDato);


            Console.ReadKey();

        }
    }
}
