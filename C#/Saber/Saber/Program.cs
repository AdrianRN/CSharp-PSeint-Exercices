using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saber
{
    class Program
    {
        static void Main(string[] args)

        {
            //Saber
            //inicio 
            Console.WriteLine("¿Listo para jugar?.");
            Console.WriteLine("Escoje tu juego!!:");
            Console.WriteLine("1: JUEGO NÚMERO SECRETO");
            Console.WriteLine("2: AÑOS BISIESTOS.");
            Console.WriteLine("3: FECHA DOMINGO DE PASCUA.");
            Console.WriteLine("4: RAÌCES.");
            Console.WriteLine("5: SERIE DE FIBONACCI.");
            Console.WriteLine("6: SALIR");

            int Opcion_A = int.Parse(Console.ReadLine());
            switch (Opcion_A)
            {
                case 1:
                    //a)	JUEGO NÚMERO SECRETO: El ordenador elegirá un número al azar entre 1 y 100. El usuario irá introduciendo números por teclado, y el ordenador le irá dando pistas: "mi número es mayor" o "mi número es menor", hasta que el usuario acierte. Entonces el ordenador le felicitará y le comunicará el número de intentos que necesitó para acertar el número secreto.
                    Random R_A = new Random();
                    int val_A = R_A.Next(1, 100);
                    int num_A;
                    int An_A = 0;
                    Console.Clear();
                    Console.WriteLine("Juego de numero secreto");
                    Console.WriteLine("elegir un numero del 1 al 100");
                    do
                    {
                        num_A = int.Parse(Console.ReadLine());
                        if (num_A < val_A)
                        {
                            Console.WriteLine("Es mayor >");
                        }
                        else if (num_A > val_A)
                        {
                            Console.WriteLine("Es menor <");
                        }
                        An_A++;

                    }
                    while (num_A != val_A);
                    Console.WriteLine("¡¡FELICIDADES!!");
                    Console.WriteLine("NÙMERO DE INTETOS: " + An_A);
                    Console.ReadKey();
                    break;

                case 2:
                    //   B)	AÑOS BISIESTOS: Determinar cuántos años bisiestos existen dentro de un periodo dado por el usuario.Ejemplo: 1999 a 2010 = 3 años bisiestos; un año es bisiesto si es múltiplo de 4 salvo el caso en que sea múltiplo de 100, que no es bisiesto, y no sea múltiplo de 400.Por ejemplo, el año 1900 no fue bisiesto, el año 2000 sí y el 2100 no lo es.
                    int AÑO;

                    Console.WriteLine("Ingresa el año");
                    AÑO = int.Parse(Console.ReadLine());
                    if (AÑO % 4 == 0 && AÑO % 100 != 0 || AÑO % 400 == 0)
                    {
                        Console.WriteLine("El año {0} es bisiesto:", AÑO);
                    }

                    else
                    {
                        Console.WriteLine("El año {0} no es bisiesto:", AÑO);
                    }

                    Console.ReadLine();
                    break;


                case 3:
                    //   C) FECHA DOMINGO DE PASCUA: La fecha de cualquier domingo de pascua se calcula de la siguiente forma: sea X el año para el que se quiere calcular la fecha. Sea A el resto de la división de X entre 19, sea B el resto de la división de X entre 4, sea C el resto de la división de X entre 7,  sea D el resto de la división de (19*A+24) entre 30, sea E el resto de la división de (2*B+4*C+6*D+5) entre 7. La fecha para el domingo de pascuales el día (22+D+E) de marzo (observese que puede dar una fecha en mes de abril). Escribir un programa que pida como entrada un año y saque por pantalla la fecha del domingo de pascua para ese año.

                    Console.Clear();
                    Console.WriteLine("DOMINGO DE PASCUA.");
                    Console.WriteLine("Ingresa el año del que desea conocer la fecha de domingo de pascua:");
                    int X_A = int.Parse(Console.ReadLine());
                    int A_A, B_A, C_A, D_A, E_A, Dia_A;
                    A_A = X_A % 19;
                    B_A = X_A % 4;
                    C_A = X_A % 7;
                    D_A = (19 * A_A + 24) % 30;
                    E_A = (2 * B_A + 4 * C_A + 6 * D_A + 5) % 7;
                    Dia_A = (22 + D_A + E_A);
                    if (Dia_A <= 31)
                    {
                        Console.WriteLine("La fecha de domingo de pascua es:" + Dia_A + " Marzo");
                    }
                    else
                    {
                        Console.WriteLine("La fecha es " + (Dia_A - 31) + " de Abril");
                    }
                    Console.ReadKey();

                    break;

                case 4:
                    //D) RAÍCES: El programa deberá calcular las raíces, bien reales o imaginarias de una ecuación de segundo grado. El programa también debe ser capaz de operar con valores nulos para el coeficiente de orden dos (es decir, deberá de ser capaz de resolver ecuaciones de primer grado).
                    Console.WriteLine("RAICES.");
                    double A_a, B_a, C_a, D_a, E_a, F_a, G_a, H_a, option;
                    D_a = 0;
                    E_a = 0;
                    F_a = 0;
                    G_a = 0;
                    H_a = 0;
                    option = 0;

                    do
                    {
                        Console.WriteLine("Ingresa A:");
                        A_a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa B:");
                        B_a = Double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa C:");
                        C_a = Double.Parse(Console.ReadLine());

                        D_a = ((B_a * B_a) - (4 * A_a * C_a));
                        E_a = ((2) * (A_a));

                        if (E_a <= 0)
                        {
                            Console.WriteLine("LA RAÌZ ES:", +E_a);
                            option = Double.Parse(Console.ReadLine());

                        }
                        else
                        {
                            if (D_a <= 0)
                            {
                                Console.WriteLine("NO EXISTE LA RAÌZ.");
                                option = Double.Parse(Console.ReadLine());
                            }
                            else
                            {
                                H_a = Math.Sqrt(D_a);
                                F_a = (((-B_a) + (H_a)) / E_a);
                                G_a = (((-B_a) - (H_a)) / E_a);

                                Console.WriteLine("La Raìz X1:" + F_a);
                                Console.WriteLine("La Raìz X2:" + G_a);
                                Console.WriteLine("Vuelve a ingresar");
                                option = Double.Parse(Console.ReadLine());

                            }
                        }
                    }
                    while (option == 1);
                    break;

                case 5:
                    //E) SERIE FIBONACCI: Pedirle al usuario que ingrese diez valores enteros de los cuales el programa deberá calcular la sucesión de Fibonacci en donde se suma siempre los últimos dos números, ejemplo, si el usuario ingresa: 0,1,1,2,3,5,8,13,21,34...el programa resolvería  (0+1=1 / 1+1=2 / 1+2=3 / 2+3=5 / 3+5=8 / 5+8=13 / 8+13=21 / 13+21=34...), Así sucesivamente, hasta el infinito. Por regla, la sucesión de Fibonacci se escribe así: n = n-1 + n-2

                    Console.WriteLine("Serie Fibonacci");

                    Console.WriteLine("Ingresa el primer valor:");
                    int Val1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo valor:");
                    int Val2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el tercer valor:");
                    int Val3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el cuarto valor:");
                    int Val4 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el quinto valor:");
                    int Val5 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el sexto valor:");
                    int Val6 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el septimo valor:");
                    int Val7 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el octavo valor:");
                    int Val8 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el noveno valor:");
                    int Val9 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el decimo valor:");
                    int Val10 = int.Parse(Console.ReadLine());

                    Console.Clear();


                    int Suma_To = Val1 + Val2;
                    int Sum_2 = Val2 + Val3;
                    int Sum_3 = Val3 + Val4;
                    int Sum_4 = Val4 + Val5;
                    int Sum_5 = Val5 + Val6;
                    int Sum_6 = Val6 + Val7;
                    int Sum_7 = Val7 + Val8;
                    int Sum_8 = Val8 + Val9;
                    int Sum_9 = Val9 + Val10;

                    Console.WriteLine(":", +Suma_To);
                    Console.WriteLine(":", +Sum_2);
                    Console.WriteLine(":", +Sum_3);
                    Console.WriteLine(":", +Sum_4);
                    Console.WriteLine(":", +Sum_5);
                    Console.WriteLine(":", +Sum_6);
                    Console.WriteLine(":", +Sum_7);
                    Console.WriteLine(":", +Sum_8);
                    Console.WriteLine(":", +Sum_9);

                    break;


                case 6:
                    //G)	PRESIONAR CUALQUIER OTRA LETRA PARA SALIR
                    Console.WriteLine("GOODBYE.");
                    break;



            }

            Console.ReadKey();
        }
    }
}