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
            int cant1, cant2, cant3, cant4, cant5;
            float tp1, tp2, tp3, tp4, tp5, prec1, prec2, prec3, prec4, prec5;
            //Entrada 1
            Console.WriteLine("Ingresa el precio del producto 1: ");
            prec1 = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos llevó?");
            cant1 = int.Parse(Console.ReadLine());

            //entrada 2
            Console.WriteLine("Ingresa el precio del segundo producto: ");
            prec2 = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos llevó?");
            cant2 = int.Parse(Console.ReadLine());

            //entrada 3
            Console.WriteLine("Ingresa el precio del tercer producto: ");
            prec3 = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos llevó?");
            cant3 = int.Parse(Console.ReadLine());

            //entrada 4
            Console.WriteLine("Ingresa el precio del cuarto producto: ");
            prec4 = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos llevó?");
            cant4 = int.Parse(Console.ReadLine());

            //entrada 5
            Console.WriteLine("Ingresa el precio del quinto producto: ");
            prec5 = float.Parse(Console.ReadLine());
            Console.WriteLine("¿Cuántos productos llevó?");
            cant5 = int.Parse(Console.ReadLine());


            //procesos (1-5)
            tp1 = prec1 * cant1;
            tp2 = prec2 * cant2;
            tp3 = prec3 * cant3;
            tp4 = prec4 * cant4;
            tp5 = prec5 * cant5;



            int tprod = cant1 + cant2 + cant3 + cant4 + cant5; //contador del total de productos
            //salidas
            Console.WriteLine("Usted llevó " + tprod + " Productos de los cuales");
            Console.WriteLine("llevó " + cant1 + " de $" + prec1 + ", en total: " + tp1);
            Console.WriteLine("llevó " + cant2 + " de $" + prec2 + ", en total: " + tp2);
            Console.WriteLine("llevó " + cant3 + "de $" + prec3 + ", en total: " + tp3);
            Console.WriteLine("llevó " + cant4 + "de $" + prec4 + ", en total: " + tp4);
            Console.WriteLine("llevó " + cant5 + "de $" + prec5 + ", en total: " + tp5);



            Console.ReadKey();
        }
    }
}
