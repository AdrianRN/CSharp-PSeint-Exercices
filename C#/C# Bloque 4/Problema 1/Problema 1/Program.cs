using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            sbyte sbyDato;
            byte byDato;
            ushort ushDato;
            uint uiDato;
            ulong uloDato;
            char chDato;


            //Entrada por el usuario
            Console.WriteLine("Ingrese un numero");
            sbyDato = sbyte.Parse(Console.ReadLine());

            //conversiones
            byDato =  (byte)sbyDato;
            ushDato = (ushort)sbyDato;
            uiDato = (uint)sbyDato;
            uloDato = (ulong)sbyDato;
            chDato = (char)sbyDato;




            //Salidas, mostrar las conversiones
            Console.WriteLine("byte : {0}", byDato);
            Console.WriteLine("ushort : {0}", ushDato);
            Console.WriteLine("uint : {0}", uiDato);
            Console.WriteLine("ulong : {0}", uloDato);
            Console.WriteLine("char : {0}", chDato);


          
            Console.ReadKey();





        }
    }
}
