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
            double total, iva, totalhambes, totalhambsenc, totalrefresco, totalpapas, canthamb_es, canthamb_senc, cantrefresco, cantpapas, total_pagar;
            int hamb_es = 35;
            int hamb_senc = 25;
            int refresco = 15;
            int papas = 20;

            //entradas
            Console.WriteLine("Bienvenido al restaurante AdriansitoFelizQuierePasarProgramacion!  Muy largo eh...\n");
            Console.WriteLine("Mira nuestro menu!");
            Console.WriteLine("Hamburgesa especial $35, Hamburgesa sencilla $25, Refresco (Solo tenemos de uno, no preguntes $15, papas $20");


            Console.WriteLine("\n\n¿Cuántas hamburgesas especiales desea comprar?");
            canthamb_es = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántas hamburgesas sencillas desea comprar?");
            canthamb_senc = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántos refrescos desea comprar?");
            cantrefresco = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Cuántas órdenes de papas desea comprar?");
            cantpapas = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");

            //procesos
            totalhambes = canthamb_es * hamb_es;
            totalhambsenc = canthamb_senc * hamb_senc;
            totalrefresco = cantrefresco * refresco;
            totalpapas = cantpapas * papas;
            total = totalhambes + totalhambsenc + totalrefresco + totalpapas;
            iva = total * 0.16;
            total_pagar = total + iva;





            //salidas  (ticket de compra)
            Console.WriteLine(canthamb_es + "   Hamburgesa especial   " + "$" + totalhambes);
            Console.WriteLine(canthamb_senc + "   Hamburgesa sencilla   " + "$" + totalhambsenc);
            Console.WriteLine(cantrefresco + "   Refresco              " + "$" + totalrefresco);
            Console.WriteLine(cantpapas + "   Papas                 " + "$" + totalpapas);




            Console.WriteLine("Total a pagar:            $" + total_pagar);

            Console.WriteLine("Gracias Por su compra!");
            Console.WriteLine("Vuelva pronto...!");


            Console.ReadKey();


        }
    }
}
