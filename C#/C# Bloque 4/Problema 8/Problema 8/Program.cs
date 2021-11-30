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
            //variables
            ulong uloDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            int iDato;
            uint uiDato;
            long loDato;
            char chDato;


            //entrada
            Console.WriteLine("Ingrese un numero");
            uloDato = ulong.Parse(Console.ReadLine());


            //conversiones, proceso
            sbyDato = (sbyte)uloDato;
            byDato = (byte)uloDato;
            shDato = (short)uloDato;
            ushDato = (ushort)uloDato;
            iDato = (int)uloDato;
            uiDato = (uint)uloDato;
            loDato = (long)uloDato;
            chDato = (char)uloDato;


            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("long: {0}", loDato);
            Console.WriteLine("char: {0}", chDato);


            Console.ReadKey();

        }
    }
}
