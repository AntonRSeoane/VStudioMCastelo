﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.");
            Console.Write("   a)");
            int i = 1;
            while (i <= 11)
            {
                Console.Write(i + ", ");
                i += 2;
            }
            Console.WriteLine(" ");
            Console.Write("   b)");
            i = 2;
            while (i <= 10)
            {
                Console.Write(i + ", ");
                i += 2;
            }
            Console.WriteLine(" ");
            Console.Write("   c)");
            i = 5;
            while (i <= 25)
            {
                Console.Write(i + ", ");
                i += 5;
            }
            Console.WriteLine(" ");
            Console.Write("   d)");
            i = 100;
            while (i >= 50)
            {
                Console.Write(i + " ");
                i -= 10;
            }
            Console.WriteLine(" ");
            Console.WriteLine("2.");
            Console.Write("   c)");
            Console.Write("El ciclo se repetirá cinco veces.");
            Console.WriteLine(" ");
            
            Console.WriteLine("3.");
            Console.Write("   a)");
            i= 10;
            while (i <= 100)
            {
                Console.Write(i + " ");
                i = i + 10;
            }
            Console.WriteLine(" ");
            Console.WriteLine("     La intención de este bucle es contar de 10 a 100.");

            Console.WriteLine(" ");
            Console.Write("   b)");
            i = 100;
            while (i > 80)
            {
                Console.Write(2 * i);
                i -= 2;
            }
            Console.WriteLine(" ");
            Console.WriteLine("     El resultado de este bucle es hacer un número juntando los números resultados.");

            Console.WriteLine(" ");
            Console.Write("   c)");
            i = 50;
            int j = 100;
            while (i < j)
            {
                Console.Write(i + " ");
                j -= 10;
                i += 10;
            }
            Console.WriteLine(" ");
            Console.WriteLine("     El resultado de este bucle es contar de 50 a 70.");

            Console.WriteLine(" ");
            Console.Write("   d)");
            i = 100; j = 1;
            int n = 50;
            while (i >= n)
            {
                Console.Write(2 * j);

                j += 2;
                i -= 10;
            }
            Console.WriteLine(" ");
            Console.WriteLine("     El resultado de este bucle es hacer un número juntando los números resultados.");

            Console.WriteLine(" ");
            Console.Write("   e)");
            int x = 0;
            i = 0;
            while (i < 20)
            {
                if (i % 5 == 0)
                {
                    x += i;
                }
                i += 1;
            }
            Console.WriteLine(x);
            Console.WriteLine("     El resultado de este bucle es 30.");

            Console.WriteLine(" ");
            Console.Write("   f)");
            x = 100; i = 1; 
            int s = 8;
            while (i < x)
            {
                s += 1;
                i *= 2;
            }
            Console.WriteLine(s);
            Console.WriteLine("     El resultado de este bucle es un número formado por todos los resultados de s juntos.");

            Console.WriteLine(" ");
            Console.Write("   g)");
            x = 100; i = 1; s = 1;
            for (i = 2; i < x; i++)
            {
                s += i;
                i *= 10;
            }
            Console.WriteLine(s);
            Console.WriteLine("     El resultado de este bucle es un número formado por todos los resultadot de s juntos.");

            Console.WriteLine(" ");
            Console.Write("   h)");
            i = 1;
            for (i = 1; i < 10; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(i);
            Console.WriteLine("    El resultado de este bucle es un listado de números del 1 al 10 contados de forma impar.");

            Console.WriteLine("4.");

            Console.WriteLine("   a) El fallo es que hace que se le sume 1 a x si i es múltiplo de 5, pero el valor de i no es múltiplo de 5 ni hacen que pueda ser valor de 5.");
            Console.WriteLine(" ");
            Console.WriteLine("   b) El fallo es que no se le exige ninguna condición a x.");
            Console.WriteLine(" ");
            Console.WriteLine("   c) El fallo es que pone la orden de imprimir los valores de s por pantalla fuera del bucle, el cual se repite infinitamente,");
            Console.WriteLine(" ");

            Console.Write("5. ");
            int a = 320, b = 160;
            while (a >= b)
            {
                Console.Write(a + " ");
                a -= 20;
            }
            Console.WriteLine(" ");

            Console.Write("6. ");
            a = 0;
            for (a = 0; a < 100; a++)
            {
                if (a % 5 == 0 ||  a % 7 == 0)
                {
                    Console.Write(a + " ");
                }
            }
            Console.WriteLine(" ");

            Console.Write("7. ");
            Console.Write("  Inserte un número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            a = 0;
            while (a <= 10)
            {
                Console.WriteLine($"{b} * {a} = {b * a}");
                a += 1;
            }
            Console.WriteLine(" ");

            Console.Write("8. ");
            Console.Write(" Inserte un número: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            a = 0;
            while (a <= 4)
            {
                Console.WriteLine($"    | {b} | {Math.Pow(b, 2)} | {Math.Pow(b, 3)} |");
                b += 1;
                a += 1;
            }
            Console.WriteLine(" ");

            Console.WriteLine("9.");
            Console.WriteLine("    N     raiz(n)");


            for (double nn = 16.0; nn >= 1.0; nn -= 2.5)
            {

                Console.WriteLine($"    {nn}     {Math.Sqrt(nn)}");


            }
            Console.WriteLine(" ");


            Console.Write("10.");
            Console.Write(" Inserte un número: ");
            int m = Convert.ToInt32(Console.ReadLine());

            while (m < 0)
            {
                Console.Write(" Inserte el número (no negativo): ");
                m = Convert.ToInt32(Console.ReadLine());
            }
            int suma = m;

            while (m >= 1)
            {
                suma += (m - 1);
                m -= 1;
            }
            Console.WriteLine(" " + suma);

            Console.Write("11.");
            Console.Write(" Inserte un número: ");
            int v = Convert.ToInt32(Console.ReadLine());
            while (v < 0)
            {
                Console.Write(" Inserte el número (no negativo): ");
                v = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("12. Inserte un número:");
            int numero = int.Parse(Console.ReadLine());
            
            while (numero < 0)
            {
                Console.Write("12. Inserte un número no negativo:");
                numero = int.Parse(Console.ReadLine());
            }
            
            
            List<int> divisores = new List<int>();
            
            for (int c = 1;  c < numero; c++)
            {
                if (numero % c == 0)
                {
                      divisores.Add(c); 
                }
            }

            Console.WriteLine($"Los divisores de {numero} son:" + numero);
            foreach (int divisor in divisores)
            {
                Console.Write(divisor + " ");
            }
            Console.WriteLine();

            Console.WriteLine("13. Ingrese un número: ");
            int testNumeroPerfecto = Convert.ToInt32(Console.ReadLine());
            int suma2 = 0;
            Console.WriteLine("Los divisores del número " + testNumeroPerfecto + " son ");
            for (int k = 1; k < testNumeroPerfecto; k++)
            {
                if (testNumeroPerfecto % k == 0)
                {
                    suma2 += k;
                    Console.WriteLine(k);
                }
            }
            if (suma2 == testNumeroPerfecto)
            {
                Console.WriteLine($"El número {testNumeroPerfecto} es un número perfecto");
            }
            else
            {
                Console.WriteLine($"El número {testNumeroPerfecto} NO es un número perfecto");
            }

            Console.WriteLine("14. Inserte un número: ");

            int nnn = Convert.ToInt32(Console.ReadLine());
            int suma3 = 0;
            while (nnn < 0)
            {
                Console.WriteLine("Inserte un número NO negativo: ");
                nnn = Convert.ToInt32(Console.ReadLine());
                
            }
            Console.WriteLine($"Los {nnn} primeros múltiplos de 5 son:");
            for (int jota = 1; jota <= nnn; jota++)
            {
                if (jota % 5 == 0)
                {
                    Console.WriteLine($"{jota}");
                    suma3 += jota;
                }
            }
            Console.Write($"Y su suma es {suma3}");

            Console.WriteLine("15. Inserte un número: ");
            int n4 = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            while (n4 < 0)
            {
                Console.WriteLine("Inserte un número NO negativo");
            }
            for (int jj = 1; jj <= n4; jj++)
            {
                fact = fact * jj;           
            }
            Console.WriteLine("Factorial de " + n4 + " es " + fact + ".");

            Console.ReadLine();
        }
    }
}
