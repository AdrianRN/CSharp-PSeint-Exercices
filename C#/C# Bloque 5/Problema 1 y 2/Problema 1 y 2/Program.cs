using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_c
{
    class Program
    {
        static void Main()
        {
            //variables
            Console.WriteLine("Ingrese un valor: ");
            string stDato = Console.ReadLine();


            //Procesos, conversiones
            decimal decDato = decimal.Parse(stDato);
            decimal decDato2 = Convert.ToDecimal(stDato);
            float flDato = Convert.ToSingle(stDato);
            float flDato2 = float.Parse(stDato);
            double douDato = double.Parse(stDato);
            double douDato2 = Convert.ToDouble(stDato);
            short shDato = short.Parse(stDato);
            short shDato2 = Convert.ToInt16(stDato);
            int iDato = int.Parse(stDato);
            int iDato2 = Convert.ToInt32(stDato);
            long loDato = long.Parse(stDato);
            long loDato2 = Convert.ToInt64(stDato);
            uint uiDato = uint.Parse(stDato);
            uint uiDato2 = Convert.ToUInt32(stDato);
            ulong uloDato = ulong.Parse(stDato);
            ulong uloDato2 = Convert.ToUInt64(stDato);



            //Salida de datos
            Console.WriteLine("decimal en Parse: " + decDato);
            Console.WriteLine("decimal en Convert: " + decDato2);
            Console.WriteLine("float en Parse es: {0}", flDato2);
            Console.WriteLine("float en Convert es: " + flDato);
            Console.WriteLine("double en Parse es: {0}", douDato);
            Console.WriteLine("double en Convert es: " + douDato2);
            Console.WriteLine("short en Parse es: {0}", shDato);
            Console.WriteLine("short en Convert es: " + shDato2);
            Console.WriteLine("int en Parse es: {0}", iDato);
            Console.WriteLine("int en Convert es: " + iDato2);
            Console.WriteLine("long en Parse es: {0}", loDato);
            Console.WriteLine("long en Convert es: " + loDato2);
            Console.WriteLine("uint en Parse es: {0}", uiDato);
            Console.WriteLine("uint en Convert es: " + uiDato2);
            Console.WriteLine("ulong en Parse es: {0}", uloDato);
            Console.WriteLine("ulong en Convert es: " + uloDato2);


            Console.ReadKey();

        }
    }
}
