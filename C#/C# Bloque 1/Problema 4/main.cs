using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    float rec_base, rec_altura, area;

    //entrada
    Console.Write("Ingrese base del rectangulo ");
    rec_base = float.Parse(Console.ReadLine());

    Console.Write("Ingrese altura del rectangulo ");
    rec_altura = float.Parse(Console.ReadLine());

    //proceso
    area = rec_base * rec_altura;

    //salida
    Console.WriteLine("El area del rectangulo es: " + area);

    Console.ReadKey();






  }
}