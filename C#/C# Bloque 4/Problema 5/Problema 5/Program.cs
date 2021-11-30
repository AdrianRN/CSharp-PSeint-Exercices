using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            int iDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            uint uiDato;
            ulong uloDato;
            char chDato;

            //entrada
            Console.WriteLine("Ingrese un numero");
            iDato = int.Parse(Console.ReadLine());

            //conversiones proceso
            sbyDato = (sbyte)iDato;
            byDato = (byte)iDato;
            shDato = (short)iDato;
            ushDato = (ushort)iDato;
            uiDato = (uint)iDato;
            uloDato = (ulong)iDato;
            chDato = (char)iDato;


            //mostrar
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("ulong: {0}", uloDato);
            Console.WriteLine("char: {0}", chDato);

            Console.ReadKey();


        }
    }
}
