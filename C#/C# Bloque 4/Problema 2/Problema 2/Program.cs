using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declarar variables que se van a usar
            byte byDato;
            sbyte sbyDato;
            char chDato;

            //entrada y leer numero ingresado
            Console.WriteLine("Ingrese un numero");
            byDato = byte.Parse(Console.ReadLine());

            //procesos, conversiones
            sbyDato = (sbyte)byDato;
            chDato = (char)byDato;

            //salida, mostrar
            Console.WriteLine("sbyte: {0}", sbyDato);
            Console.WriteLine("char: {0}", chDato);

            Console.ReadKey();



        }
    }
}
