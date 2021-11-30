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
            //variables
            long loDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            int iDato;
            uint uiDato;
            ulong uloDato;
            char chDato;

            //entrada
            Console.WriteLine("Ingrese un numero");
            loDato = long.Parse(Console.ReadLine());

            //conversiones, proceso
            sbyDato = (sbyte)loDato;
            byDato = (byte)loDato;
            shDato = (short)loDato;
            ushDato = (ushort)loDato;
            iDato = (int)loDato;
            uiDato = (uint)loDato;
            uloDato = (ulong)loDato;
            chDato = (char)loDato;

            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("ulong: {0}", uloDato);
            Console.WriteLine("char: {0}", chDato);




            Console.ReadKey();


        }
    }
}
