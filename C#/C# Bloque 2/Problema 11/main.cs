using System;

class MainClass {
  public static void Main (string[] args) {
  	//variables
    int Km, Cambios;
    //Entrada
    Console.WriteLine("Ingrese la cantidad de kilómetros a recorrer: ");
    Km = int.Parse(Console.ReadLine());
    //Proceso
    Cambios = (Km / 5000);
    //Salida
    Console.WriteLine("Estos son los cambios de aceite a realizar: " + Cambios);
    Console.ReadKey();
  }
}