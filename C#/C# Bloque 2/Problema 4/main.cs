using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double a, resultado;

    //entradas
    Console.WriteLine("Ingrese valor de a ");
    a = double.Parse(Console.ReadLine());

    //proceso
    resultado = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(2, a));

    //salida
    Console.WriteLine("El resultado de la expresion es: " + resultado);


    Console.ReadKey();





  }
}