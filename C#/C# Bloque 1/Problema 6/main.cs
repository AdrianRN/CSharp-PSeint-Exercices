using System;

class MainClass {
  public static void Main (string[] args) {
    //variables
    int calif_1, calif_2, calif_3, calif_4, calif_5, promedio;

    //entradas
    Console.WriteLine("Ingrese valor de la calificacion 1: ");
    calif_1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de la calificacion 2: ");
    calif_2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de la calificacion 3: ");
    calif_3 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de la calificacion 4: ");
    calif_4 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese valor de la calificacion 5: ");
    calif_5 = int.Parse(Console.ReadLine());


    //proceso
    promedio = (calif_1 + calif_2 + calif_3 + calif_4 + calif_5) / 5;

    //salida
    Console.WriteLine("El promedio de las calificaciones es: "+ promedio);

    Console.ReadKey();
    




  }
}