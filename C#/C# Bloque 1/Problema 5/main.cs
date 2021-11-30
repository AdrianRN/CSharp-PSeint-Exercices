using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    float triangulo_b, triangulo_h, area ; 

    //entradas
    Console.WriteLine("Ingresa base del triangulo: ");
    triangulo_b = float.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa altura del triangulo: ");
    triangulo_h = float.Parse(Console.ReadLine());

    //proceso
    area = (triangulo_b * triangulo_h) / 2;

    //salidas
    Console.WriteLine("El area del triangulo es: " + area);



    Console.ReadKey();

    

  }
}