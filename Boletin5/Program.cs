using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
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

            Console.WriteLine("16. Inserte un número: ");
            int n16 = Convert.ToInt32(Console.ReadLine());
            int mult3 = 0;
            while (n16 < 0)
            {
                Console.WriteLine("Inserte un número NO negativo: ");
                n16 = Convert.ToInt32(Console.ReadLine());
            }
                Console.Write($"Los múltiplos de 3 menores que {n16} son: ");
            for (int w =1; w < n16; w++)
            {
                
                if (w % 3 == 0 )
                {
                    Console.WriteLine($"{w} ");
                    mult3 += 1;
                }
            }
            Console.WriteLine($"Debajo de {n16} hay {mult3} múltiplos de 3.");


            Console.WriteLine("17. Inserte un número: ");
            int n17 = Convert.ToInt32(Console.ReadLine());
            int numDivs = 0;
            Console.WriteLine($"Los divisores de {n17} son:");
            for (int i17 = 1; i17 <= n17; i17++)
            {
                if (n17 % i17 == 0)
                {
                    Console.WriteLine(i17);
                    numDivs += 1;
                }
            }
            Console.WriteLine("La cantidad de divisores de " + n17 + " es " + numDivs + ".");

            Console.WriteLine("18. Inserte un número: ");
            int n18 = Convert.ToInt32(Console.ReadLine());
            int esPrimo = 1;
            while (n18 < 0)
            {
                Console.WriteLine("El número debe ser positivo. Inserte un número: ");
                n18 = Convert.ToInt32(Console.ReadLine());
            }
            for (int k18 = 2; k18 < n18; k18++)
            {
                if (n18 % k18 == 0)
                {
                    esPrimo = 0;
                }
            }
            if (esPrimo == 1)
            {
                Console.Write("El número " + n18 + " es primo.");
            }
            else
            {
                Console.WriteLine("El número " + n18 + " no es primo.");
            }

            Console.WriteLine("19. Valor para N: ");
            int n19 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("    Valor para M: ");
            int m19 = Convert.ToInt32(Console.ReadLine());

            for (int posicion = n19; posicion <= m19; posicion++)
            {
                posicion += 1;
                if (posicion % 3 == 0 && posicion % 5 == 0 && posicion % 7 == 0)
                {
                    Console.WriteLine($"El primer número múltiplo de 3, 5 y 7 entre {n19} y {m19} es {posicion}.");
                }
                else
                {
                    Console.WriteLine($"El número {posicion} no es múltiplo de 3, 5 y 7.");
                }
            }

            Console.WriteLine("20. Hoy mostraremos la tabla de multiplicar de los 10 primeros números.");
            int n20 = 1;
            int m20 = 0;
            for (n20 = 1; n20 <= 10;)
            {
                for (m20 = 0; m20 <= 10;)
                {
                    Console.WriteLine($"{n20} * {m20} = {n20 * m20}");
                    m20 += 1;
                }
                Console.WriteLine(" ");
                n20 += 1;
                m20 = 0;
            }

            Console.WriteLine(" ");
            Console.WriteLine("21.");
            Console.WriteLine("   a)");

            for (int nReps = 7; nReps >= 0; nReps--)
            {
                for (int nTxt = nReps; nTxt >= 0; nTxt--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("   b)");

            for (int nReps = 1; nReps <= 7; nReps++)
            {
                for (int nTxt = 1; nTxt <= nReps; nTxt++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("  c)");

            for (int nReps = 1; nReps <= 5; nReps++)
            {
                for (int nTxt = 1; nTxt <= nReps; nTxt++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            for (int nReps = 3; nReps >= 0; nReps--)
            {
                for (int nTxt = nReps; nTxt >= 0; nTxt--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("  d)");
            int numDisp = 1;
            for (int nReps = 6; nReps >= 0; nReps--)
            {
                for (int nTxt = nReps; nTxt >= 0; nTxt--)
                {
                    Console.Write(numDisp + " ");
                    numDisp += 1;
                }
                numDisp = 1;
                Console.WriteLine("\n");
            }

            Console.WriteLine("  e)");
            numDisp = 1;

            for (int nReps = 6; nReps >= 0; nReps--)
            {
                for (int nTxt = nReps; nTxt >= 0; nTxt--)
                {
                    Console.Write(numDisp + " ");
                }
                numDisp += 1;
                Console.WriteLine("\n");
            }

            Console.WriteLine("23. Inserte un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int nTest = num; nTest >= 1; nTest--)
            {
                int suma23 = 0;
                for (int k = 1; k < nTest; k++)
                {
                    if (nTest % k == 0)
                    {
                        suma23 += k;
                    }
                }
                if (suma23 == nTest)
                {
                    Console.WriteLine($"El número {nTest} es un número perfecto");
                }
            }

            Console.WriteLine("24. Inserte un número: ");
            int num24 = Convert.ToInt32(Console.ReadLine());

           
            int Nprimos = 0;
            
            for (int jj = 1; jj <= num24; jj++)
            {
                esPrimo = 1;

                for (int k24 = 2; k24 < jj; k24++)
            {
                if (jj % k24 == 0)
                {
                    esPrimo = 0;
                }
            }
            if (esPrimo == 1)
            {
                Console.WriteLine("El número " + jj + " es primo.");
                Nprimos++;
            }
            }
            Console.WriteLine($"Hay {Nprimos} números primos.");

            Console.WriteLine("25. Números aleatorios entre -5 y 5.");

            Random rnd = new Random();
            
            for (int c25 = 1; c25 <= 10; c25++)
            {
                int numNeg = 0;
                int numPos = 0;
                int numRango = 0;
                for (int jjj = 1; jjj <= 10; jjj++)
                {
                    int n25 = rnd.Next(-5, 5); 
                    Console.Write(n25 + " ");
                    if (n25 < 0)
                    {
                        numNeg++;
                    }
                    else if (n25 > 0)
                    {
                        numPos++;
                    }
                    if (n25 >= -2 && n25 <= 2)
                    {
                        numRango++;
                    }
                }
                Console.WriteLine($"Números positivos: {numPos}. Números negativos: {numNeg}. Porcentaje de números entre -2 y 2: {numRango * 10}%. \n");
            }

            Console.WriteLine("Práctica Final: Juego de números.");
            Console.WriteLine("Pulse enter para proceder.");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.Clear();
            Console.Title = "Práctica Final: Juego de números";
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.Write("       Inserte nombre de usuario: ");
            string nomUsu = Console.ReadLine();
            Console.Clear();

            Thread.Sleep(1000);
            Console.WriteLine($"Bot: Hola {nomUsu}, hoy te desafiaré a un juego en el que yo pensaré un número al azar y tú tendrás que adivinar cuál es.");
            Console.WriteLine("                                                                                 (Enter para continuar)");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Bot: ¡Basta de cháchara! Comencemos. ");
            Thread.Sleep(2000);
            Console.Clear();
            Random numerito = new Random();
            int numSel = numerito.Next(1, 15);
            Console.WriteLine("Bot: Ya he pensado un número entre 1 y 15. Tienes 3 intentos.");
            int vidas = 3;
            Console.Write($"{nomUsu}: ");
            int respuesta = Convert.ToInt32(Console.ReadLine());
            if (respuesta == numSel)
            {
                Console.WriteLine("      *HAS PASADO AL SEGUNDO NIVEL*");
                Console.WriteLine("Bot: Veo que tienes más capacidad de lo que yo creía. Ahora dime uno entre 1 y 30.");
                numSel = numerito.Next(1, 30);
                Thread.Sleep(2000);
                vidas = 4;
                Console.WriteLine("Bot: Y como soy un 'pana humilde' como decís vosotros, tienes 4 intentos.");
                numSel = Convert.ToInt32(Console.ReadLine());
                if (respuesta == numSel)
                {
                    Console.WriteLine("      *HAS PASADO AL SEGUNDO NIVEL*");

                    Console.WriteLine($"Bot: Tú has querido esto, {nomUsu}. Dime un número entre 1 y 50.");
                    numSel = numerito.Next(1, 50);
                    Thread.Sleep(2000);
                    Console.WriteLine($"      *UN PERRO APARECIDO DE LA NADA HA DECIDIDO ALIARSE CONTIGO, POR LO TANTO TIENES 6 VIDAS*");
                    Thread.Sleep(2000);
                    Console.WriteLine($"Bot: ¡Chispa! ¿Qué haces? Siento no haberte hecho caso aquel día por haber estado jugando al Super Mario.");
                    vidas = 6;
                    Console.Write(nomUsu + ": ");
                    respuesta = Convert.ToInt32(Console.ReadLine());
                    if (respuesta == numSel)
                    {
                        Console.WriteLine("Bot: ¡NO! ¡ESTO NO PUEDE ESTAR OCURRIENDO!");
                        Thread.Sleep(2000);
                        Console.WriteLine("Bot: ¡NOOOOOOOO.....!");
                        Thread.Sleep(3000);
                        Console.WriteLine($"      *Y ASÍ ES COMO {nomUsu} HA DERROTADO AL MALVADO MAGO*");
                    }
                    else
                    {
                        while (vidas > 0)
                        {
                            Console.WriteLine($"Bot: ¡Mal! Te quedan {vidas} intentos.");
                            Console.Write(nomUsu + ": ");
                            vidas -= 1;
                            respuesta = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                }
                else
                {
                    while (vidas > 0)
                    {
                        Console.WriteLine($"Bot: ¡Mal! Te quedan {vidas} intentos.");
                        Console.Write(nomUsu + ": ");
                        vidas -= 1;
                        respuesta = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Bot: Has perdido.");
                }
            }
            else
            {
                while (vidas > 0)
                {
                    Console.WriteLine($"Bot: ¡Mal! Te quedan {vidas} intentos.");
                    Console.Write(nomUsu + ": ");
                    vidas -= 1;
                    respuesta = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Bot: Has perdido.");
            }

            Console.ReadLine();
        }
    }
}
