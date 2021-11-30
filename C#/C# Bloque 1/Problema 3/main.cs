using System;

class MainClass {
  public static void Main (string[] args) {
    
  //variables
  float lado, volumen;


  //entradas
  Console.WriteLine("Ingrese lado del cubo");
  lado = float.Parse(Console.ReadLine());


  //proceso
  volumen = lado * lado * lado;


  //salida
  Console.WriteLine("El volumen del cubo es: " + volumen);


  Console.ReadKey();
  }




}