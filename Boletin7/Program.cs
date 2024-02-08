using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace Tema7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Puse el ejercicio 11 de último porque es el más bello de todos.");
            Thread.Sleep(3000);
            Console.WriteLine("         Enter para continuar...");
            Console.ReadLine();
            Console.Clear();

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
                Console.WriteLine($"El dominio del correo electrónico {email} es: {dominio}.");
            }
            else
            {
                Console.WriteLine("Eso no es un email, trampos@.");
            }

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 8******");

            Console.Write("Inserte un código: ");
            string codigo = Console.ReadLine();

            try
            {
                if (char.IsLetter(codigo[0]) && char.IsLetter(codigo[1]) && char.IsDigit(codigo[2]) && char.IsDigit(codigo[3]))
                {
                    Console.WriteLine($"Ese código es válido.");
                }
                else
                {
                    Console.WriteLine("Ese código es inválido.");
                }
            }
            catch 
            {
                Console.WriteLine("Ese código es inválido.");
            }
            

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 9******");

            Console.Write("Escribe algo: ");
            string entrada9 = Console.ReadLine();
            entrada9 = entrada9.Replace(' ', '*');

            Console.WriteLine(entrada9);

            Console.ReadLine();


            Console.WriteLine("******EJERCICIO 22******");

            Console.Write("Ruta: ");
            string rutaFichero = Console.ReadLine();

            StreamReader lector = new StreamReader(rutaFichero);

            Console.WriteLine(lector.Read());

            lector.Close();

            Console.ReadLine();

            Console.WriteLine("******EJERCICIO 11******");

            string[] lista = new string[4];
            lista[0] = "montecastelo";
            lista[1] = "visual";
            lista[2] = "programacion";
            lista[3] = "informatica";
            Random rnd = new Random();
            string objetivo = lista[rnd.Next(0, lista.Length - 1)];
            bool ganar = false;
            char letra2;
            int contar = 0;
            string busc = "";
            int vidas = 6;

            Console.WriteLine("ADVERTENCIA: \n SI TIENE PROBLEMAS MENTALES O CARDÍACOS, SE LE RECOMIENDA QUE ACUDA CON UN PROFESIONAL ANTES DE INTERACTUAR CON ESTE PROGRAMA. \n PUEDE RESULTAR DEMASIADO MARAVILLOSO PARA ALGUNOS PÚBLICOS.");
            Console.ReadLine();
            Console.Clear();
            Thread.Sleep(5000);
            Console.WriteLine("     \\     |                                   |                                  _)        \r\n    _ \\    __ \\    _ \\    __|  __|   _` |   _` |   _ \\        __|  _ \\  __ `__ \\   | \\ \\  / \r\n   ___ \\   | | |  (   |  |    (     (   |  (   |  (   |      |     __/  |   |   |  |  `  <  \r\n _/    _\\ _| |_| \\___/  _|   \\___| \\__,_| \\__,_| \\___/      _|   \\___| _|  _|  _| _|  _/\\_\\ \r\n                                                                                            ");
            Console.Beep(659, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(659, 125);
            Thread.Sleep(167);
            Console.Beep(494, 125);
            Console.Beep(659, 125);
            Thread.Sleep(125);
            Console.Beep(784, 125);
            Thread.Sleep(375);
            Console.Beep(330, 125);
            Thread.Sleep(375);

            Console.WriteLine("         Enter para comenzar");
            Console.ReadLine();
            Console.Clear();
            Console.Write("\n \n \n     Escoja nombre de usuario: ");
            string usuario = Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"Juez Juanma Quillaje: ¡Silencio en la corte! Estamos aquí para discutir el caso de {usuario}, a quien se ha acusado de jugar con LEGOs a la edad de 100 años, ignorando que la caja claramente establece una edad máxima de 99 años. ¿Cómo se declara la persona culpable?");
            Console.ReadLine();
            Console.WriteLine("Abogada Lucía: Su Señoría, mi cliente se declara inocente. Sí, es cierto que la edad indicada en la caja es hasta los 99 años, pero argumentamos que esa restricción es arbitraria y no tiene base legal para imponerse.");
            Console.ReadLine();
            Console.WriteLine($"Fiscal Jason Thores: ¡Objeción, Su Señoría! La restricción de edad está claramente especificada en la caja del producto. {usuario} ha violado claramente los términos de uso establecidos por el fabricante.");
            Console.ReadLine();
            Console.WriteLine($"Abogada Lucía: Sugiero que {usuario} se enfrente a usted, Su Señoría, en una partida de ahorcado. Si gana, se demostrará su inocencia y se retirarán los cargos en su contra.");
            Console.ReadLine();
            Console.WriteLine($"Juez Juanma Quillaje: Muy bien, acepto el desafío. ¿Está de acuerdo, fiscal?");
            Console.ReadLine();
            Console.WriteLine($"Fiscal Jason Thores: Me parece justo, Su Señoría.");
            Console.ReadLine();
            do
            {
                Console.Write("Inserta letra en minúscula y sin tildes: ");
                letra2 = Convert.ToChar(Console.ReadLine());

                if (char.IsLetter(letra2) && objetivo.Contains(letra2))
                {
                    for (int i = 0; i < objetivo.Length; i++)
                    {
                        char caracter = objetivo[i];
                        busc = busc + caracter;

                        if (busc.Contains(letra2))
                        {
                            contar++;
                            busc = "";
                        }
                    }
                    Console.WriteLine($"Acertaste. Te quedan {objetivo.Length - contar} letras.");
                }
                else
                {
                    vidas -= 1;
                    Console.WriteLine("No acertaste. Te quedan " + vidas + " intentos.");
                }

                if (contar >= objetivo.Length)
                {
                    Console.WriteLine("¡Ganaste!");
                    Console.WriteLine("¡A celebrar!");
                    Thread.Sleep(6000);
                    ganar = true;
                    Process.Start("https://youtu.be/5CODNk_D0GM?si=dCWiRJSjJ-24zEhS");
                    break;
                }

                if (vidas <= 0)
                {
                    Console.WriteLine("¡Perdiste! La palabra era " + objetivo);
                    break;
                }


            } while (ganar == false);

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