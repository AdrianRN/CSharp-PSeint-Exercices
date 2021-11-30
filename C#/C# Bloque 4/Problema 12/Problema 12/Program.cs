using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            decimal decDato;
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
            double douDato;

            //entrada
            Console.WriteLine("Ingrese un numero");
            decDato = decimal.Parse(Console.ReadLine());

            //procesos conversiones
            sbyDato = (sbyte)decDato;
            byDato = (byte)decDato;
            shDato = (short)decDato;
            ushDato = (ushort)decDato;
            iDato = (int)decDato;
            uiDato = (uint)decDato;
            loDato = (long)decDato;
            uloDato = (ulong)decDato;
            chDato = (char)decDato;
            flDato = (float)decDato;
            douDato = (double)decDato;

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
            Console.WriteLine("double: {0}", douDato);


            Console.ReadKey();
        }
    }
}
