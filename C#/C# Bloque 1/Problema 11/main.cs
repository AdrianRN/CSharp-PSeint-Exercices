using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double kelvin, celcius;

    //entradas
    Console.WriteLine("Ingrese grados kelvin a convertir: ");
    kelvin = double.Parse(Console.ReadLine());

    //proceso
    celcius = kelvin - 273.15;

    //salida
    Console.WriteLine("grados kelvin ingresados convertidos a celsius son: " + celcius);


    Console.ReadKey();




  }
}