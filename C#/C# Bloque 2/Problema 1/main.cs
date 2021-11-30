using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double x, y, z, resultado;

    //entradas
    Console.Write("Ingrese valor de x ");
    x = double.Parse(Console.ReadLine());

    Console.Write("Ingrese valor de y ");
    y = double.Parse(Console.ReadLine());

    Console.Write("Ingrese valor de z ");
    z = double.Parse(Console.ReadLine());

    //proceso
    resultado = Math.Pow((5 * x + 3 * y + 4 * z), 2) * 2;

    //salida
    Console.WriteLine("El resultado de la expresion matematica es: " + resultado);

    Console.ReadKey();

   

  }
}