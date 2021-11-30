using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            uint uiDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;
            ushort ushDato;
            int iDato;
            char chDato;

            //entrada
            Console.WriteLine("Ingresa un numero");
            uiDato = uint.Parse(Console.ReadLine());

            //conversiones, proceso

            sbyDato = (sbyte)uiDato;
            byDato = (byte)uiDato;
            shDato = (short)uiDato;
            ushDato = (ushort)uiDato;
            iDato = (int)uiDato;
            chDato = (char)uiDato;

            //salidas
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short: {0}", ushDato);
            Console.WriteLine("ushort: {0}", ushDato);
            Console.WriteLine("int: {0}", iDato);
            Console.WriteLine("char: {0}", chDato);




            Console.ReadKey();


        }
    }
}
