using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double a, b, c, resultado;

    //entradas
    Console.Write("Ingrese el valor de a ");
    a = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor de b ");
    b = double.Parse(Console.ReadLine());

    Console.Write("Ingrese el valor de c ");
    c = double.Parse(Console.ReadLine());

    //proceso
    resultado = Math.Pow(a, 2) / b + Math.Pow(b, 2) / c + Math.Pow(c, 2) / a;

    //salida
    Console.WriteLine("El resultado de la expresion es: " + resultado);


    Console.ReadKey();


    











  }
}