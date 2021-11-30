using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    float metros, centimetros;

    //entradas
    Console.WriteLine("Ingrese metros a convertir: ");
    metros = float.Parse(Console.ReadLine());

    //proceso
    centimetros = metros * 100;

    //salida
    Console.WriteLine("Metros ingresados convertidos a centimetros son: " + centimetros);


    Console.ReadKey();




  }
}