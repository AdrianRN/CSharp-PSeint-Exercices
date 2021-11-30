using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
   float metros, decimetros;

   //entradas
   Console.WriteLine("Ingrese metros a convertir: ");
   metros = float.Parse(Console.ReadLine());

   //proceso
   decimetros = metros * 10;

   //salidas
   Console.WriteLine("Metros ingresados convertidos a decimetros son: " + decimetros);

   Console.ReadKey();

  }
}