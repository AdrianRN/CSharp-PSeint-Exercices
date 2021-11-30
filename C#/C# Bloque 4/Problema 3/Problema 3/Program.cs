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
          short shDato;

            //enrtrada
            Console.WriteLine("Ingrese un numero");
            shDato = short.Parse(Console.ReadLine());


            //conversiones
            sbyte sbyDato = (sbyte)shDato;
            byte byDato = (byte)shDato;
            ushort ushDato = (ushort)shDato;
            uint uiDato = (uint)shDato;
            ulong uloDato = (ulong)shDato;
            char chDato = (char)shDato;

            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("uint: {0}", uiDato);
            Console.WriteLine("ulong: {0}", uloDato);
            Console.WriteLine("char: {0}", chDato);


            Console.ReadKey();



        }
    }
}
