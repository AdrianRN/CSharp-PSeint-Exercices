using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable
            char chDato;
            sbyte sbyDato;
            byte byDato;
            short shDato;

            //entrada
            Console.WriteLine("Ingresa un caracter");
            chDato = char.Parse(Console.ReadLine());

            //proceso, conversiones
            sbyDato = (sbyte)chDato;
            byDato = (byte)chDato;
            shDato = (short)chDato;

            //salida
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("byte: {0}", byDato);
            Console.WriteLine("short {0}", shDato);

            Console.ReadKey();
            


        }
    }
}
