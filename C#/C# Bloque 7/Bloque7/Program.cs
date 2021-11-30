using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloque7
{
    class Program
    {
        static void Main(string[] args)
        {
            float opcion;
            Console.WriteLine("BLOQUE7  -Estructuras de decision");
            Console.WriteLine("Ingrese una opcion (1 - 10)");
            opcion = float.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    //ejercicio 1
                    //Entradas
                    Console.WriteLine("PROBLEMA1: Elabora un programa en consola C#, en donde el usuario ingrese un número entero, después se deberá mostrar si el número indicado tiene uno o dos dígitos.");
                    int home, num1;
                    Console.WriteLine("Ingrese un número: ");
                    num1 = int.Parse(Console.ReadLine());
                    //Procesos
                    if (num1 > -10 && num1 < 10)
                    {
                        Console.WriteLine("El numero tiene un digito");
                    }
                    else if (num1 > -100 && num1 < 100)
                    {
                        Console.WriteLine("El numero tiene dos digitos");
                    } 
                    else if(num1 >-1000 && num1<1000)
                    {
                        Console.WriteLine("El numero tiene tres digitos");
                    }
                    else
                    {
                        Console.WriteLine("Tiene mas de tres digitos");
                    }

                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 2:
                    //Ejercicio 2
                    //Entradas
                    Console.WriteLine("PROBLEMA2: Elabora un programa en consola C#, en donde el usuario proporciona cinco calificaciones, calcula el promedio y muestra si la calificación es aprobatoria (calificacion>=7) o reprobada");
                    float calif1, calif2, calif3, calif4, calif5, prom;
                    Console.WriteLine("Ingresa la primera calificación: ");
                    calif1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la segunda calificación: ");
                    calif2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la tercera calificación: ");
                    calif3 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la cuarta calificación: ");
                    calif4 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa la quinta calificación: ");
                    calif5 = float.Parse(Console.ReadLine());
                    //Procesos
                    prom = (calif1 + calif2 + calif3 + calif4 + calif5) / 5;
                    if (prom >= 7)
                    {
                        Console.WriteLine("Calificacion aprobatoria");
                    }
                    else
                    {
                        Console.WriteLine("Calificacion reprobatoria");
                    }
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 3:
                    //Ejercicio 3
                    //Entradas
                    Console.WriteLine("PROBLEMA3: Elabora un programa en consola c#, en donde el usuario proporcione cinco números y nos diga cuáles números son mayores a 10");
                    int num, num2, num3, num4, num5;
                    Console.WriteLine("Ingrese el primer número: ");
                    num = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer número: ");
                    num3 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el cuarto número: ");
                    num4 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el quinto número: ");
                    num5 = int.Parse(Console.ReadLine());
                    //Procesos
                    Console.WriteLine(num >= 10 ? "El primer número es mayor a 10" : "El primer número es menor a 10");

                    Console.WriteLine(num2 >= 10 ? "El segundo número es mayor a 10" : "El segundo número es menor a 10");

                    Console.WriteLine(num3 >= 10 ? "El tercer número es mayor a 10" : "El tercer número es menor a 10");

                    Console.WriteLine(num4 >= 10 ? "El cuarto número es mayor a 10" : "El cuarto número es menor a 10");

                    Console.WriteLine(num5 >= 10 ? "El quinto número es mayor a 10" : "El quinto número es menor a 10");
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 4:
                    //Ejercicio 4
                    Console.WriteLine("PROBLEMA4: Elabora un programa en consola C# en donde el usuario ingrese tres números y nos muestre cual es el mayor de ellos");
                    int num_1, num_2, num_3;
                    //Entradas
                    Console.WriteLine("Ingrese el primer número: ");
                    num_1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    num_2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el tercer número: ");
                    num_3 = int.Parse(Console.ReadLine());
                    //Procesos
                    if (num_1 >= num_2  &&  num_1 >= num_3)
                    {
                        Console.WriteLine("El primer numero es mayor");
                    }
                    else if(num_2 > num_3)
                    {
                        Console.WriteLine("El segundo numero es mayor");
                    }
                    else
                    {
                        Console.WriteLine("El tercer numero es mayor");
                    }



                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 5:
                    //Ejercicio 5
                    Console.WriteLine("PROBLEMA5: Elabora un programa en consola C# en donde el usuario ingrese un número entero y muestre si es par o impar");
                    double numA;
                    //Entradas
                    Console.WriteLine("Ingrese un número: ");
                    numA = double.Parse(Console.ReadLine());
                    //Procesos
                    if (numA % 2 == 0)
                    {

                        Console.WriteLine("El número es par");
                    }

                    else
                    {
                        Console.WriteLine("El número es impar");
                    }
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 6:
                    //Ejercicio 6
                    Console.WriteLine("PROBLEMA6: Elabora un programa en consola C# en donde el usuario ingrese cinco números y nos muestre si son positivos, negativos o son igual a cero");
                    double Z1, Z2, Z3, Z4, Z5;
                    //Entradas
                    Console.WriteLine("Ingrese el primer número: ");
                    Z1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo número: ");
                    Z2 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el tercer número: ");
                    Z3 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el cuarto número: ");
                    Z4 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el quinto número: ");
                    Z5 = double.Parse(Console.ReadLine());
                    
                    //Procesos
                    if (Z1 >= 0.1)
                    {
                        Console.WriteLine("El primer número es positivo");
                    }
                    else if (Z1 <= -0.1)
                    {
                        Console.WriteLine("El primer número es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El primer número es cero");
                    }
                    if (Z2 >= 0.1)
                    {
                        Console.WriteLine("El segundo número es positivo");
                    }
                    else if (Z2 <= -0.1)
                    {
                        Console.WriteLine("El segundo número es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El segundo número es cero");
                    }
                    if (Z3 >= 0.1)
                    {
                        Console.WriteLine("El tercer número es positivo");
                    }
                    else if (Z3 <= -0.1)
                    {
                        Console.WriteLine("El tercer número es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El tercer número es cero");
                    }
                    if (Z4 >= 0.1)
                    {
                        Console.WriteLine("El cuarto número es positivo");
                    }
                    else if (Z4 <= -0.1)
                    {
                        Console.WriteLine("El cuarto número es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El cuarto número es cero");
                    }
                    if (Z5 >= 0.1)
                    {
                        Console.WriteLine("El quinto número es positivo");
                    }
                    else if (Z5 <= -0.1)
                    {
                        Console.WriteLine("El quinto número es negativo");
                    }
                    else
                    {
                        Console.WriteLine("El quinto número es cero");
                    }
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 7:
                    //Ejercicio7
                    Console.WriteLine("PROBLEMA7: Elabora un programa en consola C# en donde el usuario ingrese la edad de una persona y el sexo de la misma (1. Masculino, 2. Femenino) de dos personas y nos muestre de qué sexo es la persona mayor de edad");
                    //Entradas
                    string sex1, sex2;

                    Console.WriteLine("Ingrese la edad de la primer persona: ");
                    int edad1 = int.Parse(Console.ReadLine()); //variable declarada aqui mismo

                    Console.WriteLine("Ingrese el sexo de la primer persona: ");
                    sex1 = Console.ReadLine();

                    Console.WriteLine("Ingrese la edad de la segunda persona: ");
                    int edad2 = int.Parse(Console.ReadLine());  //variable declarada aqui mismo

                    Console.WriteLine("Ingrese el sexo de la segunda persona: ");
                    sex2 = Console.ReadLine();
                    //Procesos
                    if (edad1 > edad2)
                    {
                        Console.WriteLine("El sexo de la persona mayor de edad es: {0}" , sex1);
                    }
                    else
                    {
                        Console.WriteLine("El sexo de la persona mayor de edad es: {0}", sex2);
                    }
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 8:
                    //Ejercicio 8
                    Console.WriteLine("PROBLEMA8: Elabora un programa en consola C# en donde el usuario seleccione si quiere calcular el área y perímetro de una de las siguientes figuras: cuadrado, triángulo, rectángulo, círculo");

                    //entradas
                    int figura;
                    Console.WriteLine("Ingrese el numero dependiendo de la figura que desea ver su area y perimetro \ncuadrado = 1\n triangulo = 2\n rectangulo = 3\n circulo = 4");
                    figura = int.Parse(Console.ReadLine());

                    int lado_cuadrado, area_cuadrado, perimetro_cuadrado, base_triangulo, altura_triangulo, lado_triangulo, area_triangulo, perimetro_triangulo, base_rectangulo, altura_rectangulo, area_rectangulo, perimetro_rectangulo;

                    double radio_circulo, perimetro_circulo, area_circulo;


                    //proceso
                    if (figura == 1)
                    {
                        Console.WriteLine("Figura seleccionada: CUADRADO");
                        Console.WriteLine("Ingresa el lado del cuadrado");
                        lado_cuadrado = int.Parse(Console.ReadLine());

                        area_cuadrado = lado_cuadrado * lado_cuadrado;
                        perimetro_cuadrado = lado_cuadrado * 4;

                        //salida
                        Console.WriteLine("El area del cuadrado es: " + area_cuadrado);
                        Console.WriteLine("El perimetro del cuadrado es: " + perimetro_cuadrado);

                    } else if (figura ==2)
                    {
                        Console.WriteLine("Figura seleccionada: TRIANGULO");
                        Console.WriteLine("Ingresa base del triangulo");
                        base_triangulo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa altura del triangulo");
                        altura_triangulo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Ingresa un lado del triangulo");
                        
                        lado_triangulo = int.Parse(Console.ReadLine());

                        area_triangulo = (base_triangulo * altura_triangulo) / 2;
                        perimetro_triangulo = lado_triangulo + lado_triangulo + lado_triangulo;

                        Console.WriteLine("El area del triangulo es: " + area_triangulo);
                        Console.WriteLine("El perimetro del triangulo es: " + perimetro_triangulo);

                    } else if (figura == 3)
                    {
                        
                        Console.WriteLine("Figura seleccionada: RECTANGULO");
                        Console.WriteLine("Ingresa base del rectangulo");
                        base_rectangulo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingresa altura del rectangulo");
                        altura_rectangulo = int.Parse(Console.ReadLine());

     

                        area_rectangulo = base_rectangulo * altura_rectangulo ;
                        perimetro_rectangulo = 2 * (base_rectangulo + altura_rectangulo);

                        Console.WriteLine("El area del triangulo es: " + area_rectangulo);
                        Console.WriteLine("El perimetro del triangulo es: " + perimetro_rectangulo);
                        


                    } else if (figura == 4)
                    {
                        Console.WriteLine("Figura seleccionada: CIRCULO");
                        Console.WriteLine("Ingresa radio del circulo");
                        radio_circulo = int.Parse(Console.ReadLine());


                        

                        area_circulo = Math.PI * (Math.Pow(radio_circulo, 2));

                        perimetro_circulo = 2 * Math.PI * radio_circulo;

                        Console.WriteLine("El area del circulo es: " + area_circulo);
                        Console.WriteLine("El perimetro del circulo es: " + perimetro_circulo);
                    }
                    //Regresar pantalla
                    Console.WriteLine("Ingresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;

                case 9:
                    //Ejercicio 9
                    Console.WriteLine("PROBLEMA9: Elabora un programa en consola C# en donde el usuario seleccione una de las siguientes opciones y realice sus respectivos calculos: 1) Suma, 2) Resta, 3) Multiplicación, 4) División, 5) Raíz Cuadrada, 6) Exponenciación, 7) Salir del programa\n");

                    //entradas
                    int numero1, numero2;


                    int operacion;
                    Console.WriteLine("Ingrese el numero dependiendo de la operacion matematica que desea ver en consola\nSuma = 1\nResta = 2\nMultiplicacion = 3\nDivision = 4\nRaiz Cuadrada = 5\nExponenciacion = 6\nSalir del programa = 7\n\n\n");

                    Console.WriteLine("Ingresa el primer numero");
                    numero1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo numero");
                    numero2 = int.Parse(Console.ReadLine());


                    Console.WriteLine("\n\nIngrese numero de operacion que desea ver");
                    operacion = int.Parse(Console.ReadLine());

                    //proceso
                    if (operacion == 1)
                    {
                        Console.WriteLine("operacion seleccionada SUMA");
                        int suma = numero1 + numero2;
                        Console.WriteLine("La suma es: " + suma);

                    } else if (operacion == 2)
                    {
                        Console.WriteLine("operacion seleccionada RESTA");
                        int resta = numero1 - numero2;
                        Console.WriteLine("La resta es: " + resta);
                    } else if (operacion == 3)
                    {
                        Console.WriteLine("operacion seleccionada MULTIPLICACION");
                        int multiplicacion = numero1 * numero2;
                        Console.WriteLine("La multiplicacion es: " + multiplicacion);
                    } else if (operacion == 4)
                    {
                        Console.WriteLine("operacion seleccionada DIVISION");
                        int division = numero1 / numero2;
                        Console.WriteLine("La division es: " + division);
                    } else if (operacion == 5)
                    {
                        Console.WriteLine("operacion seleccionada RAIZ CUADRADA");
                        double raiz1 = Math.Sqrt(numero1);
                        double raiz2 = Math.Sqrt(numero2);
                        Console.WriteLine("La raiz cuadrada del primer numero es: " + raiz1);
                        Console.WriteLine("La raiz cuadrada del segundo numero es: " + raiz2);
                    } else if (operacion == 6)
                    {
                        Console.WriteLine("operacion seleccionada EXPONENCIACION");
                        double exponenciacion = Math.Pow(numero1, numero2);
                        Console.WriteLine("el primer numero elvado al segundo numero es: " + exponenciacion);
                    } else
                    {
                        //Regresar pantalla
                        Console.WriteLine("\n\n\nIngresa 1 para regresar al menú principal");
                        home = int.Parse(Console.ReadLine());
                        if (home == 1)
                            Console.Clear();
                        Main(args);
                    }
                    break;

                case 10:
                    Console.WriteLine("PROBLEMA10: Elabora un programa en consola C# en donde el usuario ingrese la cantidad de bytes y después seleccione una de las siguientes opciones y realice sus respectivos calculos");
                    //variables
                    double by, kb, mb, gb, tb, pb, eb, zb, yb, bb, geob;
                    string caso;

                    //entradas
                    Console.WriteLine("Ingrese cantidad de bytes");
                    by = double.Parse(Console.ReadLine());

                    Console.WriteLine("¿A qué desea convertir los bytes?");
                    Console.WriteLine("a) Convertir a Kb \nb) Convertir a Mb \nc) Convertir a Gb \nd) Convertir a Tb \ne) Convertir a Pb \nf) Convertir a Eb \ng) Convertir a Zb \nh) Convertir a Yb \ni) Convertir a Bb \nj) Convertir a Geob");
                    caso = Console.ReadLine();
                    //proceso
                    switch (caso)
                    {
                        case "a":
                            Console.WriteLine("Conversion seleccionada KB");
                            kb = by / 1000;
                            Console.WriteLine("La conversion de bytes a kb es: " + kb);
                            break;


                        case "b":
                            Console.WriteLine("Conversion seleccionada MB");
                            mb = by / 1000000;
                            Console.WriteLine("La conversion de bytes a mb es: " + mb);
                            break;


                        case "c":
                            Console.WriteLine("Conversion seleccionada GB");
                            gb = by / 1000000000;
                            Console.WriteLine("La conversion de bytes a gb es: " + gb);
                            break;


                        case "d":
                            Console.WriteLine("Conversion seleccionada TB");
                            tb = by / 1000000000000;
                            Console.WriteLine("La conversion de bytes a tb es: " + tb);
                            break;


                        case "e":
                            Console.WriteLine("Conversion seleccionada PB");
                            pb = by / 1000000000000000;
                            Console.WriteLine("La conversion de bytes a pb es: " + pb);
                            break;


                        case "f":
                            Console.WriteLine("Conversion seleccionada EB");
                            eb = by / 1000000000000000000;
                            Console.WriteLine("La conversion de bytes a eb es: ");
                            break;


                        case "g":
                            Console.WriteLine("Conversion seleccionada ZB");
                            zb = by * 1.0E-21;
                            Console.WriteLine("La conversion de bytes a zb es: ");
                            break;


                        case "h":
                            Console.WriteLine("Conversion seleccionada YB");
                            yb = by * 1.0E-24;
                            Console.WriteLine("La conversion de bytes a yb es: ");
                            break;


                        case "i":
                            Console.WriteLine("Conversion seleccionada BB");
                            bb = by * 1.0E-27;
                            Console.WriteLine("La conversion de bytes a bb es: ");
                            break;


                        case "j":
                            Console.WriteLine("Conversion seleccionada Geob");
                            geob = by * 1.0E-24;
                            Console.WriteLine("La conversion de bytes a geob es: " + geob);
                            break;

                    }

                    //Regresar pantalla
                    Console.WriteLine("\n\n\nIngresa 1 para regresar al menú principal");
                    home = int.Parse(Console.ReadLine());
                    if (home == 1)
                        Console.Clear();
                    Main(args);
                    break;




                    


            }
        }
    }
}
