using System;

class MainClass {
  public static void Main (string[] args) {
  	//variables
    double dinero, mil, q, din, cien, cincuenta, veinte, cambio;
    //entradas
    System.Console.WriteLine("ingrese la cantidad de dinero");
    dinero = double.Parse(Console.ReadLine());
    //proceso

    mil = Math.Truncate(dinero/1000);
    dinero = dinero%1000;
    q = Math.Truncate(dinero/500);
    dinero = dinero%500;
    din = Math.Truncate(dinero/200);
    dinero = dinero%200;
    cien = Math.Truncate(dinero/100);
    dinero = dinero%100;
    cincuenta = Math.Truncate(dinero/50);
    dinero = dinero%50;
    veinte = Math.Truncate(dinero/20);
    dinero = dinero%20;
    cambio = dinero;

    //salida
    Console.WriteLine("son "+mil+" en billetes de mil, "+q+" en billetes de quinientos, "+din+" en billetes de doscientos, "+cien+" en billetes de cien, "+cincuenta+" en billetes de cincuenta, "+veinte+" en billetes de 20, y sobra "+cambio+ " pesos.");

    Console.ReadKey();
  }
}