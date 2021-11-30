using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloque8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BLOQUE 8");

            //variables
            int aux;
            int i;
            int m;
            int k;
            int Problema;
            int n;
            int n1;
            int max;
            int min;
            int n2;
            int n3;
            int cn1;
            int contador;
            int contadormas;
            int contadormenos;
            int contadorint;
            int contadornat;
            int contadorpar;
            int o;
            int e;
            int num;
            double resultado;
            int r;
            int r1;
            int r2;
            int r3;

            Console.WriteLine("Elige el problema 1-15:");
            Problema = int.Parse(Console.ReadLine());
            switch (Problema)
            {
                case 1:


                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números del 0 y 100");
                    i = 0;
                    Console.WriteLine("WHILE:");
                    while (i <= 100)
                    {
                        Console.WriteLine(i);
                        i++;
                    }

                    Console.WriteLine("FOR:");
                    for (i = 0; i <= 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Do ... While:");
                    i = 0;
                    do
                    {
                        Console.WriteLine(i);
                        i++;
                    }
                    while (i <= 100);
                    break;

                case 2:


                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números del 100 y 0");
                    i = 100;
                    Console.WriteLine("WHILE:");

                    while (i >= 0)
                    {
                        Console.WriteLine(i);
                        i--;
                    }
                    Console.WriteLine("FOR:");
                    for (i = 100; i >= 0; i--)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("Do ... While:");
                    i = 100;
                    do
                    {
                        Console.WriteLine(i);
                        i--;
                    }
                    while (i >= 0);

                    break;

                case 3:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números impares entre el 0 y 100");
                    i = 0;
                    Console.WriteLine("WHILE:");

                    while (i <= 100)
                    {

                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        else
                        {
                            Console.WriteLine(i + " es impar");
                        }
                        i++;

                    }
                    Console.WriteLine("FOR:");
                    for (i = 0; i <= 100; i++)
                    {

                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        else
                        {
                            Console.WriteLine(i + " es impar");
                        }


                    }
                    Console.WriteLine("Do ... While:");
                    i = 0;
                    do
                    {

                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }

                        else
                        {
                            Console.WriteLine(i + " es impar");
                        }
                        i++;

                    }
                    while (i <= 100);
                    break;

                case 4:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números pares entre el 0 y 100");
                    i = 0;
                    Console.WriteLine("WHILE:");

                    while (i <= 100)
                    {

                        if (i % 2 == 0)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(i);
                            }
                            else
                            {
                                Console.WriteLine(i + " es par");
                            }

                        }


                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }

                    Console.WriteLine("FOR:");
                    for (i = 0; i <= 100; i++)
                    {

                        if (i % 2 == 0)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(i);
                            }
                            else
                            {
                                Console.WriteLine(i + " es par");
                            }

                        }


                        else
                        {
                            Console.WriteLine(i);
                        }


                    }
                    Console.WriteLine("Do ... While:");
                    i = 0;

                    do
                    {

                        if (i % 2 == 0)
                        {
                            if (i == 0)
                            {
                                Console.WriteLine(i);
                            }
                            else
                            {
                                Console.WriteLine(i + " es par");
                            }

                        }


                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    while (i <= 100);
                    break;

                case 5:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números multiplos de 3 del 0 al 100");
                    i = 0;
                    Console.WriteLine("WHILE:");

                    while (i <= 100)
                    {

                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    Console.WriteLine("FOR:");
                    for (i = 0; i <= 100; i++)
                    {

                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }


                    }
                    Console.WriteLine("Do ... While:");
                    i = 0;

                    do
                    {

                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    while (i <= 100);
                    break;

                case 6:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números multiplos de 5 del 0 al 100");
                    i = 0;
                    Console.WriteLine("WHILE:");

                    while (i <= 100)
                    {

                        if (i % 5 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 5");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    Console.WriteLine("FOR:");
                    for (i = 0; i <= 100; i++)
                    {

                        if (i % 5 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 5");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }


                    }
                    Console.WriteLine("Do ... While:");
                    i = 0;

                    do
                    {

                        if (i % 5 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 5");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    while (i <= 100);
                    break;

                case 7:
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y mostrar la suma de los números que lo anteceden. Es decir, si el usuario ingresa 5, que sume 5+4+3+2+1");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("***************************");
                    cn1 = n1;
                    Console.WriteLine("WHILE:");

                    while (cn1 >= 1)
                    {

                        n1 = n1 + (cn1 - 1);
                        cn1--;
                    }
                    Console.WriteLine("Resultado es: " + n1);


                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y mostrar la suma de los números que lo anteceden. Es decir, si el usuario ingresa 5, que sume 5+4+3+2+1");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("***************************");

                    for (cn1 = n1; cn1 >= 1; cn1--)
                    {

                        n1 = n1 + (cn1 - 1);
                    }
                    Console.WriteLine("Resultado es: " + n1);

                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y mostrar la suma de los números que lo anteceden. Es decir, si el usuario ingresa 5, que sume 5+4+3+2+1");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("***************************");
                    cn1 = n1;


                    do
                    {

                        n1 = n1 + (cn1 - 1);
                        cn1--;
                    }
                    while (cn1 >= 1);
                    Console.WriteLine("Resultado es: " + n1);
                    break;

                case 8:
                    Console.WriteLine("Elabora un programa en consola C#, en donde cuente los multiplos de 3 desde la unidad hasta un número que ingresemos");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************" + n1 + "***************");
                    i = 1;
                    Console.WriteLine("WHILE:");

                    while (i <= n1)
                    {


                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }


                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde cuente los multiplos de 3 desde la unidad hasta un número que ingresemos");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************" + n1 + "***************");

                    for (i = 1; i <= n1; i++)
                    {


                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }


                    }
                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde cuente los multiplos de 3 desde la unidad hasta un número que ingresemos");
                    Console.WriteLine("");
                    Console.WriteLine("Escribre un numero: ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("*************" + n1 + "***************");
                    i = 1;


                    do
                    {


                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i + " es multiplo de 3");
                        }

                        else
                        {
                            Console.WriteLine(i);
                        }
                        i++;

                    }
                    while (i <= n1);
                    break;



                case 9:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números primos del 0 al 100");
                    Console.WriteLine("");
                    i = 0;
                    Console.WriteLine("WHILE:");

                    while (i <= 100)
                    {
                        o = 1;
                        contador = 0;
                        while (o <= 100)
                        {
                            if (i % o == 0)
                            {
                                contador++;

                            }
                            else
                            {

                            }
                            o++;

                        }

                        if (contador > 2)
                        {

                        }
                        else
                        {
                            Console.WriteLine(i + " es primo");
                        }
                        i++;

                    }
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números primos del 0 al 100");
                    Console.WriteLine("");

                    for (i = 0; i <= 100; i++)
                    {
                        contador = 0;
                        for (o = 1; o <= 100; o++)
                        {
                            if (i % o == 0)
                            {
                                contador++;

                            }
                            else
                            {

                            }

                        }

                        if (contador > 2)
                        {

                        }
                        else
                        {
                            Console.WriteLine(i + " es primo");
                        }

                    }
                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres los números primos del 0 al 100");
                    Console.WriteLine("");
                    i = 0;

                    do
                    {
                        o = 1;
                        contador = 0;

                        do
                        {
                            if (i % o == 0)
                            {
                                contador++;

                            }
                            else
                            {

                            }
                            o++;

                        }
                        while (o <= 100);

                        if (contador > 2)
                        {

                        }
                        else
                        {
                            Console.WriteLine(i + " es primo");
                        }
                        i++;

                    }
                    while (i <= 100);
                    break;

                case 10:

                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese 10 números, sume los positivos y reste los negativos");
                    Console.WriteLine("");

                    contadormas = 0;
                    contadormenos = 0;
                    i = 1;
                    Console.WriteLine("WHILE:");

                    while (i <= 10)
                    {
                        Console.WriteLine("ingrese numero " + i + ":");
                        num = int.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            contadormas = contadormas + num;
                        }
                        if (num < 0)
                        {
                            contadormenos = contadormenos + num;
                        }
                        i++;
                    }
                    Console.WriteLine("positivos: " + contadormas);
                    Console.WriteLine("negativos: " + contadormenos);
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese 10 números, sume los positivos y reste los negativos");
                    Console.WriteLine("");

                    contadormas = 0;
                    contadormenos = 0;

                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine("ingrese numero " + i + ":");
                        num = int.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            contadormas = contadormas + num;
                        }
                        if (num < 0)
                        {
                            contadormenos = contadormenos + num;
                        }

                    }
                    Console.WriteLine("positivos: " + contadormas);
                    Console.WriteLine("negativos: " + contadormenos);

                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese 10 números, sume los positivos y reste los negativos");
                    Console.WriteLine("");

                    contadormas = 0;
                    contadormenos = 0;
                    i = 1;


                    do
                    {
                        Console.WriteLine("ingrese numero " + i + ":");
                        num = int.Parse(Console.ReadLine());

                        if (num > 0)
                        {
                            contadormas = contadormas + num;
                        }
                        if (num < 0)
                        {
                            contadormenos = contadormenos + num;
                        }
                        i++;
                    }
                    while (i <= 10);
                    Console.WriteLine("positivos: " + contadormas);
                    Console.WriteLine("negativos: " + contadormenos);
                    break;

                case 11:

                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números e intercambie sus digitos");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el numero 1");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el numero 2");
                    n2 = int.Parse(Console.ReadLine());


                    aux = n1;
                    n1 = n2;
                    n2 = aux;

                    Console.WriteLine("numero 1 tiene valor: " + n1);
                    Console.WriteLine("numero 2 tiene valor: " + n2);
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números e intercambie sus digitos");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el numero 1");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el numero 2");
                    n2 = int.Parse(Console.ReadLine());


                    aux = n1;
                    n1 = n2;
                    n2 = aux;

                    Console.WriteLine("numero 1 tiene valor: " + n1);
                    Console.WriteLine("numero 2 tiene valor: " + n2);

                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números e intercambie sus digitos");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el numero 1");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el numero 2");
                    n2 = int.Parse(Console.ReadLine());


                    aux = n1;
                    n1 = n2;
                    n2 = aux;

                    Console.WriteLine("numero 1 tiene valor: " + n1);
                    Console.WriteLine("numero 2 tiene valor: " + n2);
                    break;

                case 12:

                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres las tablas de multiplicar de un número ingresado por el usuario del 1 al 10 y que se visualice:");
                    Console.WriteLine("");

                    Console.WriteLine("ingresa el numero:");
                    n1 = int.Parse(Console.ReadLine());
                    i = 1;
                    Console.WriteLine("WHILE:");

                    while (i <= 10)
                    {
                        Console.WriteLine(n1 + "*" + i + "=" + (n1 * i));
                        i++;
                    }



                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres las tablas de multiplicar de un número ingresado por el usuario del 1 al 10 y que se visualice:");
                    Console.WriteLine("");

                    Console.WriteLine("ingresa el numero:");
                    n1 = int.Parse(Console.ReadLine());

                    for (i = 1; i <= 10; i++)
                    {
                        Console.WriteLine(n1 + "*" + i + "=" + (n1 * i));
                    }

                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde muestres las tablas de multiplicar de un número ingresado por el usuario del 1 al 10 y que se visualice:");
                    Console.WriteLine("");

                    Console.WriteLine("ingresa el numero:");
                    n1 = int.Parse(Console.ReadLine());
                    i = 1;


                    do
                    {
                        Console.WriteLine(n1 + "*" + i + "=" + (n1 * i));
                        i++;
                    }
                    while (i <= 10);
                    break;

                case 13:

                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números, muestre los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el primer numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero:");
                    n2 = int.Parse(Console.ReadLine());
                    min = 0;
                    max = 0;
                    contadorint = 0;
                    contadornat = 0;
                    contadorpar = 0;
                    Console.WriteLine("WHILE:");

                    if (n1 > n2)
                    {
                        max = n1;
                        min = n2;
                    }
                    else if (n1 < n2)
                    {
                        max = n2;
                        min = n1;
                    }
                    else if (n1 == n2)
                    {
                        Console.WriteLine("Los dos numeros son iguales");
                    }

                    while (min <= max)
                    {
                        if (min % 2 == 0)
                        {
                            if (min == 0)
                            {
                                contadorint++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                            else
                            {
                                contadorint++;
                                contadorpar++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                        }

                        else
                        {
                            contadorint++;
                            if (min > 0)
                            {
                                contadornat++;
                            }
                        }
                        min++;
                    }
                    Console.WriteLine("********************************");
                    Console.WriteLine("Numeros enteros: " + contadorint);
                    Console.WriteLine("Numeros par: " + contadorpar);
                    Console.WriteLine("Numeros naturales: " + contadornat);
                    Console.WriteLine("********************************");
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números, muestre los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el primer numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero:");
                    n2 = int.Parse(Console.ReadLine());
                    min = 0;
                    max = 0;
                    contadorint = 0;
                    contadornat = 0;
                    contadorpar = 0;

                    if (n1 > n2)
                    {
                        max = n1;
                        min = n2;
                    }
                    else if (n1 < n2)
                    {
                        max = n2;
                        min = n1;
                    }
                    else if (n1 == n2)
                    {
                        Console.WriteLine("Los dos numeros son iguales");
                    }

                    for (; min <= max; min++)
                    {
                        if (min % 2 == 0)
                        {
                            if (min == 0)
                            {
                                contadorint++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                            else
                            {
                                contadorint++;
                                contadorpar++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                        }

                        else
                        {
                            contadorint++;
                            if (min > 0)
                            {
                                contadornat++;
                            }
                        }
                    }
                    Console.WriteLine("********************************");
                    Console.WriteLine("Numeros enteros: " + contadorint);
                    Console.WriteLine("Numeros par: " + contadorpar);
                    Console.WriteLine("Numeros naturales: " + contadornat);
                    Console.WriteLine("********************************");


                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese dos números, muestre los números naturales que hay entre ambos empezando por el más pequeño, contar cuántos números hay y cuántos de ellos son pares");
                    Console.WriteLine("");

                    Console.WriteLine("Escribe el primer numero:");
                    n1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el segundo numero:");
                    n2 = int.Parse(Console.ReadLine());
                    min = 0;
                    max = 0;
                    contadorint = 0;
                    contadornat = 0;
                    contadorpar = 0;

                    if (n1 > n2)
                    {
                        max = n1;
                        min = n2;
                    }
                    else if (n1 < n2)
                    {
                        max = n2;
                        min = n1;
                    }
                    else if (n1 == n2)
                    {
                        Console.WriteLine("Los dos numeros son iguales");
                    }


                    do
                    {
                        if (min % 2 == 0)
                        {
                            if (min == 0)
                            {
                                contadorint++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                            else
                            {
                                contadorint++;
                                contadorpar++;
                                if (min > 0)
                                {
                                    contadornat++;
                                }
                            }
                        }

                        else
                        {
                            contadorint++;
                            if (min > 0)
                            {
                                contadornat++;
                            }
                        }
                        min++;
                    }
                    while (min <= max);
                    Console.WriteLine("********************************");
                    Console.WriteLine("Numeros enteros: " + contadorint);
                    Console.WriteLine("Numeros par: " + contadorpar);
                    Console.WriteLine("Numeros naturales: " + contadornat);
                    Console.WriteLine("********************************");
                    break;

                case 14:

                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y se muestre la factorial de ese número");
                    Console.WriteLine("");

                    Console.WriteLine("Ingresa un numero:");
                    num = int.Parse(Console.ReadLine());
                    resultado = num;
                    num = num - 1;
                    i = 1;
                    Console.WriteLine("WHILE:");

                    while (num >= i)
                    {
                        resultado = num * resultado;
                        num--;
                    }
                    Console.WriteLine("el resultado es: " + resultado);
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y se muestre la factorial de ese número");
                    Console.WriteLine("");

                    Console.WriteLine("Ingresa un numero:");
                    num = int.Parse(Console.ReadLine());
                    resultado = num;
                    num = num - 1;


                    for (i = 1; num >= i; num--)
                    {
                        resultado = num * resultado;
                    }
                    Console.WriteLine("el resultado es: " + resultado);


                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde el usuario ingrese un número y se muestre la factorial de ese número");
                    Console.WriteLine("");

                    Console.WriteLine("Ingresa un numero:");
                    num = int.Parse(Console.ReadLine());
                    resultado = num;
                    num = num - 1;
                    i = 1;


                    do
                    {
                        resultado = num * resultado;
                        num--;
                    }
                    while (num >= i);
                    Console.WriteLine("el resultado es: " + resultado);
                    break;

                case 15:

                    Console.WriteLine("Elabora un programa en consola C#, en donde se le muestre al usuario las opciones de realizar: a) permutaciones con repetición, b) permutaciones sin repetición, c) combinaciones. El usuario debe proporcionar el total de valores y los grupos a formar");
                    Console.WriteLine("");
                    Console.WriteLine("Selecciona una operacion: ");
                    Console.WriteLine("**********************************");
                    Console.WriteLine("*1) Permutaciones con repeticion *");
                    Console.WriteLine("*2) Permutaciones sin repeticion *");
                    Console.WriteLine("*3) Combinaciones                *");
                    Console.WriteLine("**********************************");

                    e = int.Parse(Console.ReadLine());
                    Console.WriteLine("WHILE:");

                    switch (e)
                    {
                        case 1:
                            i = 1;
                            Console.WriteLine("Ingrese Valor de n1");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n2");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n3");
                            n3 = int.Parse(Console.ReadLine());
                            n = n1 + n2 + n3;
                            r = n;
                            n = n - 1;
                            //factorial de n
                            while (n >= i)
                            {
                                r = n * r;
                                n--;

                            }


                            //factorial de n1
                            r1 = n1;
                            n1 = n1 - 1;

                            while (n1 >= i)
                            {
                                r1 = n1 * r1;
                                n1--;

                            }

                            //factorial n2
                            r2 = n2;
                            n2 = n2 - 1;

                            while (n2 >= i)
                            {
                                r2 = n2 * r2;
                                n2--;

                            }


                            //factorial n3
                            r3 = n3;
                            n3 = n3 - 1;

                            while (n3 >= i)
                            {
                                r3 = n3 * r3;
                                n3--;

                            }
                            resultado = r1 * r2 * r3;

                            Console.WriteLine(r + "/" + resultado + "= " + (r / resultado));


                            break;

                        case 2:

                            Console.WriteLine("Ingrese un valor:");
                            m = int.Parse(Console.ReadLine());
                            resultado = m;
                            m = m - 1;
                            i = 1;

                            while (m >= i)
                            {
                                resultado = m * resultado;
                                m--;
                            }
                            Console.WriteLine("cantidad de permutaciones es: " + resultado);

                            break;

                        case 3:

                            Console.WriteLine("Ingrese un valor:");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un valor:");
                            k = int.Parse(Console.ReadLine());
                            r1 = n;
                            n = n - 1;
                            i = 1;

                            while (n >= i)
                            {
                                r1 = n * r1;
                                n--;
                            }

                            r2 = k;
                            k = k - 1;
                            i = 1;

                            while (k >= i)
                            {
                                r2 = k * r2;
                                k--;
                            }
                            Console.WriteLine(r1);
                            Console.WriteLine(r2);

                            Console.WriteLine("numero de combinaciones es: " + (r1 / r2));



                            break;





                    }
                    Console.WriteLine("FOR:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde se le muestre al usuario las opciones de realizar: a) permutaciones con repetición, b) permutaciones sin repetición, c) combinaciones. El usuario debe proporcionar el total de valores y los grupos a formar");
                    Console.WriteLine("");
                    Console.WriteLine("Selecciona una operacion: ");
                    Console.WriteLine("**********************************");
                    Console.WriteLine("*1) Permutaciones con repeticion *");
                    Console.WriteLine("*2) Permutaciones sin repeticion *");
                    Console.WriteLine("*3) Combinaciones                *");
                    Console.WriteLine("**********************************");

                    e = int.Parse(Console.ReadLine());

                    switch (e)
                    {
                        case 1:
                            i = 1;
                            Console.WriteLine("Ingrese Valor de n1");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n2");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n3");
                            n3 = int.Parse(Console.ReadLine());
                            n = n1 + n2 + n3;
                            r = n;

                            //factorial de n
                            for (n = n - 1; n >= i; n--)
                            {
                                r = n * r;


                            }


                            //factorial de n1
                            r1 = n1;


                            for (n1 = n1 - 1; n1 >= i; n1--)
                            {
                                r1 = n1 * r1;


                            }

                            //factorial n2
                            r2 = n2;


                            for (n2 = n2 - 1; n2 >= i; n2--)
                            {
                                r2 = n2 * r2;


                            }


                            //factorial n3
                            r3 = n3;


                            for (n3 = n3 - 1; n3 >= i; n3--)
                            {
                                r3 = n3 * r3;


                            }
                            resultado = r1 * r2 * r3;

                            Console.WriteLine(r + "/" + resultado + "= " + (r / resultado));


                            break;

                        case 2:

                            Console.WriteLine("Ingrese un valor:");
                            m = int.Parse(Console.ReadLine());
                            resultado = m;

                            i = 1;

                            for (m = m - 1; m >= i; m--)
                            {
                                resultado = m * resultado;

                            }
                            Console.WriteLine("cantidad de permutaciones es: " + resultado);

                            break;

                        case 3:

                            Console.WriteLine("Ingrese un valor:");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un valor:");
                            k = int.Parse(Console.ReadLine());
                            r1 = n;

                            i = 1;

                            for (n = n - 1; n >= i; n--)
                            {
                                r1 = n * r1;

                            }

                            r2 = k;

                            i = 1;

                            for (k = k - 1; k >= i; k--)
                            {
                                r2 = k * r2;

                            }
                            Console.WriteLine(r1);
                            Console.WriteLine(r2);

                            Console.WriteLine("numero de combinaciones es: " + (r1 / r2));



                            break;


                    }

                    Console.WriteLine("Do ... While:");
                    Console.WriteLine("Elabora un programa en consola C#, en donde se le muestre al usuario las opciones de realizar: a) permutaciones con repetición, b) permutaciones sin repetición, c) combinaciones. El usuario debe proporcionar el total de valores y los grupos a formar");
                    Console.WriteLine("");
                    Console.WriteLine("Selecciona una operacion: ");
                    Console.WriteLine("**********************************");
                    Console.WriteLine("*1) Permutaciones con repeticion *");
                    Console.WriteLine("*2) Permutaciones sin repeticion *");
                    Console.WriteLine("*3) Combinaciones                *");
                    Console.WriteLine("**********************************");

                    e = int.Parse(Console.ReadLine());

                    switch (e)
                    {
                        case 1:
                            i = 1;
                            Console.WriteLine("Ingrese Valor de n1");
                            n1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n2");
                            n2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese Valor de n3");
                            n3 = int.Parse(Console.ReadLine());
                            n = n1 + n2 + n3;
                            r = n;
                            n = n - 1;
                            //factorial de n

                            do
                            {
                                r = n * r;
                                n--;

                            }
                            while (n >= i);

                            //factorial de n1
                            r1 = n1;
                            n1 = n1 - 1;


                            do
                            {
                                if (n1 >= i)
                                {
                                    r1 = n1 * r1;
                                    n1--;
                                    Console.WriteLine("?? " + n1);
                                }

                            }
                            while (n1 >= i);



                            //factorial n2
                            r2 = n2;
                            n2 = n2 - 1;


                            do
                            {
                                r2 = n2 * r2;
                                n2--;

                            }
                            while (n2 >= i);


                            //factorial n3
                            r3 = n3;
                            n3 = n3 - 1;


                            do
                            {
                                r3 = n3 * r3;
                                n3--;

                            }
                            while (n3 >= i);
                            resultado = r1 * r2 * r3;
                            Console.WriteLine(r1);
                            Console.WriteLine(r2);
                            Console.WriteLine(r3);

                            Console.WriteLine(r + "/" + resultado + "= " + (r / resultado));


                            break;

                        case 2:

                            Console.WriteLine("Ingrese un valor:");
                            m = int.Parse(Console.ReadLine());
                            resultado = m;
                            m = m - 1;
                            i = 1;


                            do
                            {
                                resultado = m * resultado;
                                m--;
                            }
                            while (m >= i);
                            Console.WriteLine("cantidad de permutaciones es: " + resultado);

                            break;

                        case 3:

                            Console.WriteLine("Ingrese un valor:");
                            n = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese un valor:");
                            k = int.Parse(Console.ReadLine());
                            r1 = n;
                            n = n - 1;
                            i = 1;


                            do
                            {
                                r1 = n * r1;
                                n--;
                            }
                            while (n >= i);

                            r2 = k;
                            k = k - 1;
                            i = 1;


                            do
                            {
                                r2 = k * r2;
                                k--;
                            }
                            while (k >= i);
                            Console.WriteLine(r1);
                            Console.WriteLine(r2);

                            Console.WriteLine("numero de combinaciones es: " + (r1 / r2));

                            break;


                    }
                    break;


                    
            }


            Console.ReadKey();
        }
    }
}
