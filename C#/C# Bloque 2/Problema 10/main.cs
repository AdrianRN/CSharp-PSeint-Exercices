using System;

class MainClass {
  public static void Main (string[] args) {

  	//variables
    int km, pasos;
    //Entrada
    Console.WriteLine("Ingresa la cantidad de pasos a recorrer: ");
    pasos = int.Parse(Console.ReadLine());
    //Proceso
    km =  pasos * 2223;
    //Salida
    Console.WriteLine("La conversión de pasos a kilómetros es de: " + km);
    Console.ReadKey();
  }
}