using System;

class MainClass {
  //Metodo principal de tipo void
  public static void Main (string[] args) {
    //Declarar variables
    float lado, perimetro;

    //Entrada de datos
    Console.WriteLine("Ingrese el lado");
    lado = float.Parse(Console.ReadLine());

    //Proceso
    perimetro = lado*4;

    //Salida de datos
    Console.WriteLine("Tu perimetro es: " + perimetro) ;

    Console.ReadKey();



  }
}