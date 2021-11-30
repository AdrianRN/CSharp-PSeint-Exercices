using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double a, b, c, x1, x2;

    //entradas
    Console.WriteLine("Ingrese valor de a ");
    a = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de b ");
    b = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de c ");
    c = double.Parse(Console.ReadLine());

    //proceso
    x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - (4 *a *c))) / (2*a);
    x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - (4 *a *c))) / (2*a);

    // salida
    Console.WriteLine("El resultado de x1 es: " + x1);
    Console.WriteLine("El resultado de x2 es: " + x2);

    Console.ReadKey();


    
    











  }
}