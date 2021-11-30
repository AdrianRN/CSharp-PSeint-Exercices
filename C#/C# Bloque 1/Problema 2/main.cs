using System;

class MainClass {
  public static void Main (string[] args) {
    //variable
    float lado, area;

    //Entrada de datos
    Console.WriteLine("Ingrese el lado");
    lado = float.Parse(Console.ReadLine());


    //proceso
    area = lado * lado;


    //salida de datos
    Console.WriteLine("Tu area es: "  + area);

    Console.ReadKey();
  }
}