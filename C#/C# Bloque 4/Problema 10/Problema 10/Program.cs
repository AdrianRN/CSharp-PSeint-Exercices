using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            float flDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            int iDato;
            uint uiDato;
            long loDato;
            ulong uloDato;
            char chDato;
            decimal decDato;


            //entrada
            Console.WriteLine("Ingresa un numero");
            flDato = float.Parse(Console.ReadLine());

            //conversiones, proceso
            sbyDato = (sbyte)flDato;
            byDato = (byte)flDato;
            shDato = (short)flDato;
            ushDato = (ushort)flDato;
            iDato = (int)flDato;
            uiDato = (uint)flDato;
            loDato = (long)flDato;
            uloDato = (ulong)flDato;
            chDato = (char)flDato;
            decDato = (decimal)flDato;

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
            Console.WriteLine("decimal: {0}", decDato);

            Console.ReadKey();
        }
    }
}
