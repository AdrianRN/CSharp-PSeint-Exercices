using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            ushort ushDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            char chDato;

            //entrada
            Console.WriteLine("Ingrese un numero");
            ushDato = ushort.Parse(Console.ReadLine());

            //conversiones, proceso
            sbyDato = (sbyte)ushDato;
            byDato = (byte)ushDato;
            shDato = (short)ushDato;
            chDato = (char)ushDato;

            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", shDato);
            Console.WriteLine("char: {0}", chDato);

            Console.ReadKey();




        }
    }
}
