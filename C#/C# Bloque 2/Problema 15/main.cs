using System;

class MainClass {
  public static void Main (string[] args) {
  	//variables
    double hrs, mins, segs;
    //entrada
    System.Console.WriteLine("ingrese los segundos");
    segs = double.Parse(Console.ReadLine());

    //proceso

    hrs = Math.Truncate(segs/3600);
    segs = segs%3600;
    mins = Math.Truncate(segs/60);
    segs = segs%60;

    //salida
    Console.WriteLine("el número introducido tiene "+hrs+" horas, "+mins+" minutos, y "+segs+" segundos");

    Console.ReadKey();
  }
}