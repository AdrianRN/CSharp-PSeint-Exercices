using System;

class MainClass {
  public static void Main (string[] args) {
  	//variables
    int num, res;
    //Entrada
    Console.WriteLine("Ingresa un número a convertir: ");
     num = int.Parse(Console.ReadLine());
    //Proceso
    res = num * (-1);
    //Salida
    Console.WriteLine("La conversión es: " + res);
    Console.ReadKey();
  }
}