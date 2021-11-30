using System;

class MainClass {
  public static void Main (string[] args) {
  	//variables
    double num, mil, cen, dec, uni;

    //entradas
    System.Console.WriteLine("Ingrese el número");
    num = double.Parse(Console.ReadLine());

    //proceso
    mil = Math.Truncate(num/1000);
    num = num%1000;
    cen = Math.Truncate(num/100);
    num = num%100;
    dec = Math.Truncate(num/10);
    num = num%10;
    uni = num;

    //salida
    Console.WriteLine("el numero tiene "+mil+" unidades de mil, "+cen+" centenas, "+dec+" decenas y "+uni+" unidades");

    Console.ReadKey();
  }
}