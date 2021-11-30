using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    double salario, salud, afi, salario_restante;

    //entradas
    Console.WriteLine("Ingrese salario del empleado ");
    salario = double.Parse(Console.ReadLine());

    //proceso
    salud = salario * 0.07;
    afi = salario * 0.04;
    salario_restante = salario - salud - afi;

    //salidas
    Console.WriteLine("dinero descontado por salud: " + salud);
    Console.WriteLine("dinero descontado por afiliacion a riesgos profesionales: " + afi);
    Console.WriteLine("salario restante del empleado: " + salario_restante);

    Console.ReadKey();
  }
}