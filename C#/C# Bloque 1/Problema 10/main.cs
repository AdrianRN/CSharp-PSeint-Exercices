using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
   double metros, yardas;
   
   //entradas
  Console.WriteLine("Ingrese metros a convertir: ");
  metros = double.Parse(Console.ReadLine());

  // proceso
  yardas = metros * 1.0936;

  //salida
  Console.WriteLine("Metros ingresados convertidos a yardas son: " + yardas);


  Console.ReadKey();




  }
}