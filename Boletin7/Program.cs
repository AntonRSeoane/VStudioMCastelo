using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Eventing.Reader;

namespace Tema7
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep = false;
            do
            {
                Console.Clear();
                Console.Write("\nEscriba el número del ejercicio que desea ver: ");
                int ejercicio = Convert.ToInt32(Console.ReadLine());
                

                if (ejercicio == 1)
                {

                    Console.WriteLine("******EJERCICIO 1******");
                    Console.Title = "EJERCICIO 1";
                    string[] matriculas = new string[] { "9999-AAA", "1293-WEQ", "2223-ZZZ", "0033-QAZ", "8402-QUE", "3401-SOE", "4365-QFN", "9503-ECS", "8205-EWJ", "1353-RJG" };
                    StreamWriter escritor = new StreamWriter(Directory.GetCurrentDirectory() + "\\matriculas.txt");

                    foreach (string matric in matriculas)
                    {
                        escritor.WriteLine(matric);
                    }

                    escritor.Close();

                    Console.WriteLine("Matrículas que acaban en Z: ");
                    foreach (string matric in matriculas)
                    {

                        if (matric[matric.Length - 1] == 'Z')
                        {

                            Console.WriteLine(matric);
                        }

                        Console.WriteLine("\n");

                    }

                    Console.WriteLine("Matrículas que contienen 34: ");
                    foreach (string matric in matriculas)
                    {

                        if (matric.Contains("34"))
                        {
                            Console.WriteLine(matric);
                        }

                        Console.WriteLine("\n");

                    }

                    Console.WriteLine("Parte numérica de las matrículas: ");
                    foreach (string matric in matriculas)
                    {
                        for (int i = 0; i < matric.Length; i++)
                        {
                            if (char.IsDigit(matric[i]))
                            {
                                Console.Write(matric[i]);
                            }
                        }
                        Console.WriteLine("\n");
                    }

                    Console.WriteLine("Parte alfabética de las matrículas: ");
                    foreach (string matric in matriculas)
                    {
                        for (int i = 0; i < matric.Length; i++)
                        {
                            if (char.IsLetter(matric[i]))
                            {
                                Console.Write(matric[i]);
                            }
                        }
                        Console.WriteLine("\n");
                    }
                }
                else if (ejercicio == 2)
                {
                    Console.WriteLine("******EJERCICIO 2******");
                    Console.Title = "EJERCICIO 2";
                    Console.Write("Caracter: ");
                    char caracter2 = Convert.ToChar(Console.ReadLine());
                    Console.Write("Escriba algo: ");
                    string entrada2 = Console.ReadLine();
                    string[] palabras = entrada2.Split(' ');
                    int contador = 0;

                    foreach (string palabra in palabras)
                    {
                        if (palabra.StartsWith(Convert.ToString(caracter2)))
                        {
                            contador++;
                        }
                    }
                    if (contador == 0)
                    {
                        Console.WriteLine("No hay palabras que empiezan por {0}|{0}", caracter2);
                    }
                    else if (contador == 1)
                    {
                        Console.WriteLine("Hay " + contador + " palabra que empieza por {0}|{0}", caracter2);
                    }
                    else
                    {
                        Console.WriteLine("Hay " + contador + " palabras que empiezan por {0}|{0}", caracter2);
                    }
                }
                else if (ejercicio == 3)
                {
                    Console.WriteLine("******EJERCICIO 3******");
                    Console.Title = "EJERCICIO 3";

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
                }
                else if (ejercicio == 4)
                {
                    Console.WriteLine("******EJERCICIO 4******");
                    Console.Title = "EJERCICIO 4";

                    Console.Write("Escriba algo: ");
                    string entrada5 = Console.ReadLine();
                    string[] palabras2 = entrada5.Split(' ');
                    int contador = 0;

                    foreach (string palabra in palabras2)
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
                }
                else if (ejercicio == 5)
                {
                    Console.WriteLine("******EJERCICIO 5******");
                    Console.Title = "EJERCICIO 5";

                    bool arroba = false;

                    Console.Write("Escriba algo: ");
                    string entrada6 = Console.ReadLine();
                    string[] palabras3 = entrada6.Split(' ');
                    int contador = 0;

                    foreach (string palabra in palabras3)
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
                }
                else if (ejercicio == 6)
                {
                    Console.WriteLine("******EJERCICIO 6******");
                    Console.Title = "EJERCICIO 6";

                    Console.Write("Escriba algo: ");
                    string entrada = Console.ReadLine();
                    string[] palabras3 = entrada.Split(' ');
                    int contador = 0;

                    foreach (string palabra in palabras3)
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

                    Console.Write("Indica substring a buscar: ");
                    string substring = Console.ReadLine();

                    foreach (string palabra in palabras3)
                    {
                        if (palabra.Contains(substring))
                        {
                            contador++;
                        }
                    }
                    if (contador == 0)
                    {
                        Console.WriteLine("No hay palabras que contengan " + substring + ".");
                    }
                    else
                    {
                        Console.WriteLine("Hay " + contador + " palabra(s) que contienen " + substring + ".");
                    }
                }
                else if (ejercicio == 7)
                {
                    Console.WriteLine("******EJERCICIO 7******");
                    Console.Title = "EJERCICIO 7";

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
                }
                else if (ejercicio == 8)
                {
                    Console.WriteLine("******EJERCICIO 8******");
                    Console.Title = "EJERCICIO 8";

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
                }
                else if (ejercicio == 9)
                {
                    Console.WriteLine("******EJERCICIO 9******");
                    Console.Title = "EJERCICIO 9";

                    Console.Write("Escribe algo: ");
                    string entrada9 = Console.ReadLine();
                    entrada9 = entrada9.Replace(' ', '*');

                    Console.WriteLine(entrada9);

                    Console.ReadLine();

                }
                else if (ejercicio == 10)
                {
                    Console.WriteLine("******EJERCICIO 10******");
                    Console.Title = "EJERCICIO 10";

                    string pedro = "'Pedro Jiménez*14Julio1990?2500";
                    string maria = "'María Benítez*9070!06Agosto1998";
                    char[] div = { '*', '?', '!' };

                    string[] pedroSplits = pedro.Split(div);
                    string[] mariaSplits = maria.Split(div);

                    Console.WriteLine("Strings divididos es subStrings: ");
                    foreach (string sub in pedroSplits)
                    {
                        Console.WriteLine(sub);
                    }

                    foreach (string sub in mariaSplits)
                    {
                        Console.WriteLine(sub);
                    }

                    foreach (string sub in pedroSplits)
                    {
                        try
                        {
                            int sueldo = Convert.ToInt32(sub);

                            if (sueldo > 1000)
                            {
                                Console.WriteLine($"El sueldo de Pedro ({sueldo}) es mayor que 1000.");
                            }
                            else
                            {
                                Console.WriteLine($"El sueldo de Pedro ({sueldo}) no es mayor que 1000.");
                            }
                        }
                        catch
                        {
                            Console.WriteLine();
                        }
                    }

                    foreach (string sub in mariaSplits)
                    {
                        try
                        {
                            int sueldo2 = Convert.ToInt32(sub);

                            if (sueldo2 > 1000)
                            {
                                Console.WriteLine($"El sueldo de María ({sueldo2}) es mayor que 1000.");
                            }
                            else
                            {
                                Console.WriteLine($"El sueldo de María ({sueldo2}) no es mayor que 1000.");
                            }
                        }
                        catch
                        {
                            Console.WriteLine();
                        }
                    }
                }
                else if (ejercicio == 11)
                {
                    Console.WriteLine("******EJERCICIO 11******");
                    Console.Title = "JUEGO DE AHORCADO";
                    string[] lista = new string[5];
                    lista[0] = "montecastelo";
                    lista[1] = "visual";
                    lista[2] = "programacion";
                    lista[3] = "informatica";
                    lista[4] = "formación";
                    Random rnd = new Random();
                    string objetivo = lista[rnd.Next(0, lista.Length - 1)];

                    string revelar = objetivo;

                    for (int i = 0; i < revelar.Length; i++)
                    {
                        revelar = revelar.Replace(revelar[i], '_');
                    }

                    bool ganar = false;
                    char letra;
                    int vidas = 6;


                    Console.WriteLine("ADVERTENCIA: ESTO ES DEMASIADO ÉPICO.");
                    Console.ReadLine();
                    Console.Clear();
                    Thread.Sleep(2000);
                    Console.WriteLine(" _  _   __   __ _   ___  _  _   __   __ _    ____  ____  _  _  __  _  _ \r\n/ )( \\ / _\\ (  ( \\ / __)( \\/ ) / _\\ (  ( \\  (  _ \\(  __)( \\/ )(  )( \\/ )\r\n) __ (/    \\/    /( (_ \\/ \\/ \\/    \\/    /   )   / ) _) / \\/ \\ )(  )  ( \r\n\\_)(_/\\_/\\_/\\_)__) \\___/\\_)(_/\\_/\\_/\\_)__)  (__\\_)(____)\\_)(_/(__)(_/\\_)");
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

                    Console.WriteLine("\n         Enter para comenzar");
                    Console.ReadLine();
                    Console.Clear();
                    Console.Write("\n \n \n     Escoja nombre de usuario: ");
                    string usuario = Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine($"Juez: ¡Silencio en la corte! Estamos aquí para discutir el caso de la abuela de {usuario}, a quien se ha acusado de jugar con LEGOs a la edad de 100 años, ignorando que la caja claramente establece una edad máxima de 99 años. ¿Cómo se declara la persona culpable?");
                    Console.ReadLine();
                    Console.WriteLine("Abogada: Su Señoría, mi cliente se declara inocente. Sí, es cierto que la edad indicada en la caja es hasta los 99 años, pero argumentamos que esa restricción es arbitraria y no tiene base legal para imponerse.");
                    Console.ReadLine();
                    Console.WriteLine($"Fiscal: ¡Objeción, Su Señoría! La restricción de edad está claramente especificada en la caja del producto. La abuela de {usuario} ha violado claramente los términos de uso establecidos por el fabricante.");
                    Console.ReadLine();
                    Console.WriteLine($"Abogada: Sugiero que {usuario} se enfrente a usted, Su Señoría, en una partida de ahorcado. Si gana, se demostrará la inocencia de su abuela y se retirarán los cargos en su contra.");
                    Console.ReadLine();
                    Console.WriteLine($"Juez: Muy bien, acepto el desafío. ¿Está de acuerdo, fiscal?");
                    Console.ReadLine();
                    Console.WriteLine($"Fiscal: Me parece justo, Su Señoría.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Ayuda: Hola {usuario}, yo seré tu guía en esta extremadamente loca aventura.");
                    Console.ReadLine();
                    Console.WriteLine($"Ayuda: Tu objetivo es que vencer al juez en una partida de ahorcado. Hazlo si quieres salvar a tu abuela de ser condenada a pena de muerte por exceder el límite de edad de un juego infantil.");
                    Console.ReadLine();
                    Console.Clear();

                    while (ganar == false)
                    {

                        Console.Write("Inserta letra sin tildes: ");
                        letra = char.ToLower(Console.ReadKey().KeyChar);

                        if (objetivo.Contains(letra))
                        {
                            for (int i = 0; i < objetivo.Length; i++)
                            {
                                if (objetivo[i] == letra)
                                {
                                    revelar = revelar.Substring(0, i) + letra + revelar.Substring(i + 1);
                                }
                            }
                            Console.WriteLine("\n" + revelar);

                            Console.WriteLine($"¡Acertaste!");
                        }
                        else
                        {
                            Console.WriteLine("\n" + revelar);
                            vidas--;
                            Console.WriteLine($"¡Fallaste! Te quedan {vidas} intentos.");
                        }

                        if (vidas > 0 && !revelar.Contains('_'))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\n¡Ganaste!");
                            ganar = true;
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        if (vidas == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n¡PERDISTE! La palabra era " + objetivo);
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                        }


                    }
                    
                }
                else if (ejercicio == 22)
                {
                    Console.WriteLine("******EJERCICIO 22******");
                    Console.Title = "EJERCICIO 22";

                    Console.Write("Ruta completa de carpetas: ");
                    string rutaFichero1 = Console.ReadLine();
                    Console.Write("\nNombre de archivo: ");
                    string nombreFichero = Console.ReadLine();

                    try
                    {
                        StreamReader lector = new StreamReader(rutaFichero1 + "\\" + nombreFichero);
                        Console.WriteLine(lector.ReadLine());
                        lector.Close();
                    }
                    catch
                    {
                        Console.WriteLine("Error al buscar el archivo.");
                    }
                }
                else
                {
                    Console.WriteLine("Ejercicio no encontrado");
                }
                Console.WriteLine("\n¿Quiere ver otro ejercicio? (s/n)");
                char resp = Console.ReadKey().KeyChar;

                switch (resp)
                {
                    case 's':
                        rep = true;
                        break;
                    case 'n':
                        rep = false;
                        break;
                    
                }
            } while (rep == true);
            
        }

        static char LetraDNI(int dniNumeros)
        {
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int resto = dniNumeros % 23;
            return letras[resto];
        }

        static string ObtenerDominio(string email)
        {

            int posArroba = email.IndexOf('@');


            string dominio = email.Substring(posArroba + 1);

            return dominio;
        }
    }
}