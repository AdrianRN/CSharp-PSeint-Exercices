using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double pasos, km, m, cm;

    //entradas
    Console.Write("Ingrese pasos recorridos: ");
    pasos = double.Parse(Console.ReadLine());

    //proceso
    km = (pasos*45) / 100000;
    m = (pasos*45) / 100;
    cm = (pasos*45);

    //salida
    Console.WriteLine("Kilometros recorridos: " + km);
    Console.WriteLine("metros recorridos: " + m);
    Console.WriteLine("centimetros recorridos: " + cm);

    Console.ReadKey();










  }
}