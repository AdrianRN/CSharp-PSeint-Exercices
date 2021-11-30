using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    float metros, milimetros;

    //entradas
    Console.Write("Ingrese metros a convertir: ");
    metros = float.Parse(Console.ReadLine());

    //proceso
    milimetros = metros * 1000;

    //salida
    Console.WriteLine("Metros ingresados convertidos a milimetros son: " + milimetros) ;

    Console.ReadKey();




  }
}