using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ingresa tres números: ");
        String[] valor = { Console.ReadLine(), Console.ReadLine(), Console.ReadLine() };

        foreach (var val in valor)
        {
            int iNum;
            bool success = Int32.TryParse(val, out iNum);
            if (success)
            {
                Console.WriteLine("Tu conversión '{0}' para {1}", val, iNum);
            }
            else
            {
                Console.WriteLine("La coversión de '{0}' no ha sido exitosa", val);
            }
        }
        Console.ReadKey();

    }
}