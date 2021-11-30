using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
   double a, b, c, resultado;

   //entradas
   Console.WriteLine("Ingrese valor de a ");
   a = double.Parse(Console.ReadLine());

   Console.WriteLine("Ingrese valor de b ");
   b = double.Parse(Console.ReadLine());

   Console.WriteLine("Ingrese valor de c ");
   c = double.Parse(Console.ReadLine());

   //proceso
  resultado = ((2*a*Math.PI) / 2) + (Math.Pow(b, a)) - (a*b*c) + ((3*a*b) / Math.Sqrt(9*c));


   //salida
   Console.WriteLine("el resultado de la expresion es: " + resultado);

   Console.ReadKey();


  }
}