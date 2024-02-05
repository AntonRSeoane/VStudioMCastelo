using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******EJERCICIO 2******");
            //Cuantas palabras empiezan por A
            Console.Write("Escriba algo: ");
            string entrada2 = Console.ReadLine();
            string[] palabras = entrada2.Split(' ');
            int contador = 0;

            foreach(string palabra in palabras)
            {
                if(palabra.StartsWith("A") || palabra.StartsWith("a"))
                {
                    contador++;
                }
            }
            if(contador == 0)
            {
                Console.WriteLine("No hay palabras que empiezan por a|A");
            }
            else
            {
                Console.WriteLine("Hay " + contador + " palabra(s) que empiezan por a|A");
            }

            string entrada3 = "Kimetsu no Yaiba es la mejor serie.";
            string entrada4 = entrada3 + "Tenéis que verla.";

            entrada3 = entrada3.Replace(' ', ',');

            Console.WriteLine(entrada3);

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 3******");

            Console.WriteLine("Introduce un número de DNI:");
            string dni = Console.ReadLine();

            if (dni.Length != 9)
            {
                Console.WriteLine("El número de DNI debe tener 9 caracteres.");
                return;
            }

            string numeros = dni.Substring(0, 8);
            char letra = dni[8];

            if (!int.TryParse(numeros, out int dniNumeros))
            {
                Console.WriteLine("Los primeros 8 caracteres deben ser dígitos.");
                return;
            }

            char letraCalc = LetraDNI(dniNumeros);

            if (letra != letraCalc)
            {
                Console.WriteLine("La letra indicada no es correcta.");
            }
            else
            {
                Console.WriteLine("El número y la letra de DNI son correctos.");
            }

            Console.ReadLine();

            Console.Write("Escriba algo: ");
            string entrada5 = Console.ReadLine();
            string[] palabras2 = entrada5.Split(' ');
            contador = 0;

            foreach (string palabra in palabras)
            {
                if (palabra.StartsWith("B") || palabra.StartsWith("b"))
                {
                    Console.Write(palabra + " ");
                    contador++;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No hay palabras que empiezan por b. ");
            }

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 4******");

            bool arroba = false;

            Console.Write("Escriba algo: ");
            string entrada6 = Console.ReadLine();
            string[] palabras3 = entrada6.Split(' ');
            contador = 0;

            foreach (string palabra in palabras)
            {
                if (palabra.Contains("@"))
                {
                    arroba = true;
                    contador++;
                }
            }
            if (contador == 0)
            {
                arroba = false;
            }

            if (arroba == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 5******");

            foreach (string palabra in palabras)
            {
                if (palabra.Contains("ABA") || palabra.Contains("aba"))
                {
                    contador++;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No hay palabras que contengan aba.");
            }
            else
            {
                Console.WriteLine("Hay " + contador + " palabra(s) que contienen aba.");
            }

            Console.WriteLine("******EJERCICIO 6******");


        }
        static char LetraDNI(int dniNumeros)
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int resto = dniNumeros % 23;
            return letras[resto];
        }
    }
}
