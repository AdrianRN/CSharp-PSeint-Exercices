using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double horas_estudio, costo_t;

    //entradas
    Console.Write("Ingrese horas horas totales ");
    horas_estudio = double.Parse(Console.ReadLine());

    //proceso
    costo_t = horas_estudio * 115000;

    //salida
    Console.WriteLine("El costo total es: " + costo_t);

    Console.ReadKey();
  }
}