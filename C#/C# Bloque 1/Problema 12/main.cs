using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    float fahrenheit, celsius;

    //entradas
    Console.WriteLine("Ingrese grados Fahrenheit a convertir:");
    fahrenheit = float.Parse(Console.ReadLine());

    //proceso
    celsius = 5 * (fahrenheit-32) / 9;

    //salida
    Console.WriteLine("Grados ingresados convertidos a celsius son: " + celsius);


    Console.ReadKey();



  }
}