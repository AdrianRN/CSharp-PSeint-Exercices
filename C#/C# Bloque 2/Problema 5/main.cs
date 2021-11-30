using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double a, b, resultado;

    //entradas
    Console.WriteLine("Ingrese valor de a ");
    a = double.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de b ");
    b = double.Parse(Console.ReadLine());


    //proceso
    resultado = ((a*a) * 2 +  (b*b) * 3) / (2*a*b);

    //salida
    Console.WriteLine("El resultado de la expresion es: "+ resultado);

    Console.ReadKey();


  }
}