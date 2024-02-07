using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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

            foreach (string palabra in palabras)
            {
                if (palabra.StartsWith("A") || palabra.StartsWith("a"))
                {
                    contador++;
                }
            }
            if (contador == 0)
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

            Console.WriteLine("******EJERCICIO 4******");

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

            Console.WriteLine("******EJERCICIO 5******");

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

            Console.WriteLine("******EJERCICIO 6******");

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

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 7******");

            Console.Write("Escriba un correo: ");
            string email = Console.ReadLine();
            string dominio = ObtenerDominio(email);

            if (email.Contains('@') && email.Contains(".com"))
            {
                Console.WriteLine($"El dominio del correo electrónico {0} es: {1}", email, dominio);
            }
            else
            {
                Console.WriteLine("Eso no es un email, trampos@.");
            }

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 8******");

            Console.Write("Inserte un código: ");
            string codigo = Console.ReadLine();


            if (codigo == "AA99")
            {
                Console.WriteLine("El dominio del correo electrónico {0} es: {1}", email, dominio);
            }
            else
            {
                Console.WriteLine("Eso no es un email, trampos@.");
            }

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 9******");

            Console.Write("Escribe algo: ");
            string entrada9 = Console.ReadLine();
            entrada9 = entrada9.Replace(' ', '*');

            Console.WriteLine(entrada9);

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 11******");

            string[] lista = new string[4];
            lista[0] = "playa";
            lista[1] = "japon";
            lista[2] = "programacion";
            lista[3] = "informatica";
            Random rnd = new Random();
            string objetivo = lista[rnd.Next(0, lista.Length - 1)];
            bool ganar = false;
            char letra2;
            int contar = 0;
            string busc = "";
            int vidas = 6;

            do
            {
                Console.Write("Inserta letra en minúscula: ");
                letra2 = Convert.ToChar(Console.ReadLine());

                if (char.IsLetter(letra2) && objetivo.Contains(letra2))
                {
                    Console.WriteLine("Acertaste. ");
                    for (int i = 0;i < objetivo.Length; i++)
                    {
                        char caracter = objetivo[i];
                        busc = busc + caracter;

                        if (busc.Contains(letra2))
                        {
                            contar++;
                            busc = "";
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No acertaste. ");
                }

                if (contar == objetivo.Length)
                {
                    Console.WriteLine("¡Ganaste!");
                    ganar = true;
                    break;
                }
                
                if (vidas == 0)
                {
                    Console.WriteLine("¡Perdiste! La palabra era " + objetivo);
                    break;
                }

                
            } while (ganar == false);

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 22******");

            Console.Write("Ruta: ");
            string rutaFichero = Console.ReadLine();

            StreamReader lector = new StreamReader(rutaFichero);

            Console.WriteLine(lector);

            lector.Close();

            Console.ReadLine();


        }
        static char LetraDNI(int dniNumeros)
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int resto = dniNumeros % 23;
            return letras[resto];
        }

        static string ObtenerDominio(string email)
        {
            
            int indiceArroba = email.IndexOf('@');

            
            string dominio = email.Substring(indiceArroba + 1);

            return dominio;
        }
    }
}