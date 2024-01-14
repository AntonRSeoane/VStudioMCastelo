using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RepasoBoletin6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            int ejercicio = 4;
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            string[] ej4 = new string[6];
            ej4[0] = "Fullmetal Alchemist";
            ej4[1] = "One Piece";
            ej4[2] = "Tokyo Ghoul";
            ej4[3] = "El Imperio Final";
            ej4[4] = "Five Nights At Freddy's: Los Ojos De Plata";
            ej4[5] = "Tokyo Revengers";

            foreach (string libro in ej4)
            {
                Console.Write(libro + ", ");
            }

            //Ejercicio 5
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            short[] ej5 = new short[4];
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Valor para posición " + i + ": ");
                ej5[i] = Convert.ToInt16(Console.ReadLine());
            }

            for (int i = 0; i < 4; i++)
            {
                Console.Write(ej5[i] + ", ");
            }

            //Ejercicio 6
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            double[] ej6 = new double[5];
            ej6[4] = -1;
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write(ej6[i] + ", "); 
            }

            //Ejercicio 7
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            Console.Write("Número de posiciones para el array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ej7 = new int[n];
            Console.Write("Valor de primera posición: ");
            int v1 = Convert.ToInt32(Console.ReadLine());
            ej7[0] = v1;
            Console.Write("Valor de última posición: ");
            int v2 = Convert.ToInt32(Console.ReadLine());
            ej7[n - 1] = v2;

            //Ejercicio 8
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            Random rnd = new Random();
            int[] ej8 = new int[100];

            for (int i = 0;i < 100;i++)
            {
                ej8[i] = rnd.Next(0, 10);
                Console.Write(ej8[i] + ", ");
            }

            //Ejercicio 9
            Console.ReadLine();
            Console.Clear();

            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 7;

            n = 1;
            for (int i = 0; i < 100;)
            {
                ej8[i] = n;
                Console.Write(ej8[i] + ", ");
                i += 2;
                n += 1;
            }

            //Ejercicio 16
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int numsNeg = 0;
            Console.Write("Número de posiciones en los arrays: ");
            n = Convert.ToInt32(Console.ReadLine());
            double[] array = new double[n];

            for (int i = 0; i < array.Length;i++)
            {
                array[i] = rnd.Next(-10, 10); 
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    numsNeg += 1;
                }
            }

            Console.WriteLine($"En este array hay {numsNeg} números negativos.");

            //Ejercicio 17
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int impares = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 1)
                {
                    impares += 1;
                }
            }

            double porcentaje = (impares * 100) / array.Length;

            Console.WriteLine($"El porcentaje de números impares en el array es de {porcentaje}%.");

            //Ejercicio 18
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int vacio = 0;
            string[] strings = new string[n];

            for (int i = rnd.Next(0, strings.Length - 1); i < strings.Length; i++)
            {
                strings[rnd.Next(i, strings.Length)] = Convert.ToString(rnd.Next(0, 100));
            }

            for (int i = 0; i < strings.Length;i++)
            {
                if (strings[i] == null)
                {
                    vacio += 1;
                }
            }

            if (vacio == 1)
            {
                Console.WriteLine($"Hay en total {vacio} posiciones vacía.");
            }
            else
            {
                Console.WriteLine($"Hay en total {vacio} posiciones vacías.");
            }
            
            //Ejercicio 19
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[] array19 = new int[n];

            Console.WriteLine("Valores superiores a 1000: ");
            for (int i = 0; i < array19.Length; i++)
            {
                array19[i] = rnd.Next(0, 2000);
                if (array19[i] > 1000)
                {
                    Console.Write(array19[i] + " ");
                }
            }

            //Ejercicio 20
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int o = 0;

            bool encontrado = false;

            while (encontrado == false)
            {
                if (array19[o] > 1000)
                {
                    Console.WriteLine($"El primer valor superior a 1000 es {array19[o]} y está en la posición {o}");
                    encontrado = true;
                }
                else
                {
                    o++;
                }
            }


            //Ejercicio 21
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            o = 0;
            string[] strings21 = new string[n];


            encontrado = false;

            while (encontrado == false)
            {
                if (strings21[o] == null)
                {
                    Console.WriteLine($"El primer valor vacío está en la posición {o}");
                    encontrado = true;
                }
                else
                {
                    o++;
                }
            }

            //Ejercicio 22
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            o = 0;

            encontrado = false;

            while (encontrado == false)
            {
                if (array19[o] % 2 == 0)
                {
                    Console.WriteLine($"El primer valor par es {array19[o]} y está en la posición {o}");
                    encontrado = true;
                }
                else
                {
                    o++;
                }
            }

            //Ejercicio 23
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 2;

            o = 0;

            encontrado = false;

            while (encontrado == false)
            {
                if (array19[o] % 2 == 0)
                {
                    Console.WriteLine($"El primer valor par es {array19[o]} y está en la posición {Array.IndexOf(array19, array19[o])}");
                    encontrado = true;
                }
                else
                {
                    o++;
                }
            }

            //Ejercicio 25
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int pequeño = 0;
            for (int i = 0; i < array19.Length; i++)
            {
                if (array19[i] > pequeño)
                {
                    pequeño = array19[i];
                }
            }

            Console.WriteLine($"El valor más pequeño es {pequeño}.");

            //Ejercicio 26
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 2;

            for (int i = 0; i < array19.Length;i++)
            {
                if (array19[i] != array[i])
                {
                    Console.WriteLine($"En la posición {i} un array tiene el valor {array19[i]} y el otro el valor {array[i]}.");
                }
            }

            //Ejercicio 28
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 2;
            string[] array28 = new string[strings21.Length];

            Array.Copy(strings21, array28, strings21.Length);

            //Ejercicio 30
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 10;

            Console.Write("Inserta un tamaño: ");
            int tamaño1 = byte.Parse(Console.ReadLine());
            Console.Write("Inserta otro tamaño: ");
            int tamaño2 = byte.Parse(Console.ReadLine());

            int[] array30 = new int[tamaño1];
            Array.Resize(ref array30, tamaño2);

            //Ejercicio 40
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            Console.Write("Inserta número de posiciones: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array40 = new int[n];
            int posMayor = 0;
            int valMayor = 0;

            for (int i = 0; i < array40.Length; i++)
            {
                array40[i] = rnd.Next(0, 1000);
            }

            for (int i = 0;i < array40.Length; i++)
            {
                if (posMayor < array40[i])
                {
                    valMayor = array40[i];
                    posMayor = i;
                }
            }
            Console.WriteLine($"El mayor valor del array es {valMayor} en la posición {posMayor}.");

            //Ejercicio 41
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[] array41 = new int[5];
            int[] array2de41 = new int[5];

            for (int i = 0;i<array41.Length;i++)
            {
                array41[i] = rnd.Next(0, 1000);
            }

            Array.Copy(array41,array2de41,array41.Length);

            Array.Sort(array41);

            foreach(int i in array41)
            {
                Console.WriteLine(i + " ");
            }

            foreach(int i in array2de41)
            {
                Console.WriteLine(i + " ");
            }

            bool otro = false;
            do
            {
                Console.Write("Busca un valor: ");
                int buscar = Convert.ToInt32(Console.ReadLine());
                double resultado = Array.BinarySearch(array41, buscar);

                if(resultado == -1)
                {
                    Console.WriteLine($"No se ha encontrado {buscar}");
                }
                else
                {
                    Console.WriteLine($"Se ha encontrado {buscar} en la posición {resultado}.");
                }

                Console.WriteLine("¿Quieres buscar otro valor?");
                Console.WriteLine("     1) Sí");
                Console.WriteLine("     2) No");
                string resp = Console.ReadLine();
                if (resp == "1")
                {
                    otro = true;
                }
                else if (resp == "2")
                {
                    otro = false;
                }
            } while (otro == true);

            //Ejercicio 42
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int vPrimos = 0;
            for (int i=0; i<array2de41.Length; i++)
            {
                if (array2de41[i] % array2de41[i] == 0 && array2de41[i] % 1 == 0)
                {
                    vPrimos += 1;
                }
            }
            Console.WriteLine($"Hay {vPrimos} números primos en el array.");

            //Ejercicio 43
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[] nums = new int[25];
           
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rnd.Next(1, 101);
            }

            Console.WriteLine("Valores de la matriz:");
            
            int[] reps = new int[101];
            
            foreach (int numero in nums)
            {
                reps[numero]++;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {
                if (reps[nums[i]] > 1)
                {
                    Console.WriteLine("*" + nums[i]);
                }
                else
                {
                    Console.WriteLine(nums[i]);
                }
            }

            //Ejercicio 44
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

    
            int[,] matriz = new int[3, 3] {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

            Console.WriteLine("Ingrese el número de fila (0-2):");
            int filaSel = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Valores de la fila seleccionada:");
            for (int columna = 0; columna < 3; columna++)
            {
                Console.WriteLine(matriz[filaSel, columna]);
            }

            for (int fila = 0; fila < 3; fila++)
            {
                matriz[fila, 2] = 0;
            }

            int sumFila1 = 0;
            for (int columna = 0; columna < 3; columna++)
            {
                sumFila1 += matriz[0, columna];
            }
            Console.WriteLine("La suma de la primera fila es: " + sumFila1);

            int contaCeros = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                if (matriz[fila, 1] == 0)
                {
                    contaCeros++;
                }
            }
            Console.WriteLine("La cantidad de ceros en la segunda columna es: " + contaCeros);

            double sumaTotal = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    sumaTotal += matriz[fila, columna];
                }
            }
            double media = sumaTotal / (3 * 3);
            Console.WriteLine("La media de la matriz es: " + media);

            //Ejercicio 45
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            double[,] array45 = new double[12, 30];

            sumaTotal = 0;
            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    sumaTotal += matriz[fila, columna];
                }
            }
            Console.WriteLine("La media es " + sumaTotal / 9);

            //Ejercicio 46
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[,] array46 = new int[3, 3] { { 1, 0, 2 }, { 0, 3, 0 }, { 4, 0, 5 } };

            int elementos = array46.Length;
            int ceros = 0;

            for (int i = 0; i < array46.GetLength(0); i++)
            {
                for (int j = 0; j < array46.GetLength(1); j++)
                {
                    if (matriz[i, j] == 0)
                    {
                        ceros++;
                    }
                }
            }

            double porcentajeCeros = (ceros / (double)elementos) * 100;

            Console.WriteLine("El porcentaje de ceros en la matriz es " + porcentajeCeros + "%.");

            //Ejercicio 47
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[,] Original = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] Transpuesta = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Transpuesta[i, j] = Original[j, i];
                }
            }

            bool Simetrica = true;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (Original[i, j] != Transpuesta[i, j])
                    {
                        Simetrica = false;
                        break;
                    }
                }
            }

            if (Simetrica)
            {
                Console.WriteLine("La matriz es simétrica.");
            }
            else
            {
                Console.WriteLine("La matriz no es simétrica.");
            }

            //Ejercicio 48
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            Console.Write("Número de filas: ");
            int n2= Convert.ToInt32(Console.ReadLine());
            Console.Write("Número de columnas: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] array48 = new int[n2, m];

            int suma = 0;
            for (int i = 0; i < m; i++)
            {
                suma += array48[i, i];
            }

            Console.WriteLine("La suma de la primera fila es: " + suma);

            //Ejercicio 49
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[,] array49 = new int[n, m];

            suma = 0;
            for (int fila = 0; fila < n; fila++)
            {
                suma += array49[fila, m - 1];
            }

            Console.WriteLine("La suma de la última columna es: " + suma);

            //Ejercicio 50
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int[,] array50 = new int[,]
            {
                { 5, 2, 9 },
                { 1, 7, 3 },
                { 4, 8, 6 }
            };

            int jj = 1;

            for (int i = 0; i < array50.Length; i++)
            {
                Console.Write(array50[i, jj] + " ");
                jj++;
            }

            int sumatoria = 0;
            elementos = array50.GetLength(0) * array50.GetLength(1);

            for (int i = 0; i < array50.GetLength(0); i++)
            {
                for (int j = 0; j < array50.GetLength(1); j++)
                {
                    sumatoria += array50[i, j];
                }
            }

            media = (double)sumatoria / elementos;

            int valorMinimo = array50[0, 0];
            int valorMaximo = array50[0, 0];
            int posicionMinimoFila = 0;
            int posicionMinimoColumna = 0;
            int posicionMaximoFila = 0;
            int posicionMaximoColumna = 0;

            for (int i = 0; i < array50.GetLength(0); i++)
            {
                for (int j = 0; j < array50.GetLength(1); j++)
                {
                    if (array50[i, j] < valorMinimo)
                    {
                        valorMinimo = array50[i, j];
                        posicionMinimoFila = i;
                        posicionMinimoColumna = j;
                    }

                    if (array50[i, j] > valorMaximo)
                    {
                        valorMaximo = array50[i, j];
                        posicionMaximoFila = i;
                        posicionMaximoColumna = j;
                    }
                }
            }

            //Ejercicio 51
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            for (int i = 0; i < array50.GetLength(0); i++)
            {
                for (int j = 0; j < array50.GetLength(1); j++)
                {
                    if (array50[i, j] < 100)
                    {
                        array50[array50.Length, array50.Length] = array50[i, j]; 
                        
                    }
                }
            }

            //Ejercicio 52
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            Console.Write("Un número: ");
            n = 4;
            int[,] array52 = new int[n, n];

            for (int f  = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    array52[f, c] = rnd.Next(0, 1);
                }
            }

            bool mtri = false;
            int tri = 0;

            for (int f = 0; f < n; f++)
            {
                for(int c = 0; c < n; c++)
                {
                    if (array52[f, c] != 0)
                    {
                        tri += 1;
                    }
                }
            }

            if (tri >= 10)
            {
                mtri = true;
            }
            else
            {
                mtri = false;
            }

            if (mtri == true)
            {
                Console.WriteLine("El array es triangular.");
            }
            else
            {
                Console.WriteLine("El array no es triangular.");
            }

            //Ejercicio 53
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < n; c++)
                {
                    if (array52[f, c] != 0)
                    {
                        tri += 1;
                    }
                }
            }

            if (tri == n * n)
            {
                mtri = true;
            }
            else
            {
                mtri = false;
            }

            if (mtri == true)
            {
                Console.WriteLine("El array es cuadrado.");
            }
            else
            {
                Console.WriteLine("El array no es cuadrado.");
            }

            //Ejercicio 54
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            double[] array54 = new double[25];

            for (int e = 0; e < array54.Length; e++)
            {
                array54[e] = rnd.Next(-5,5);
            }

            double[] norepes = new double[array54.Length];

            for(int r = 0; r < array54.Length; r++)
            {
                for (int e = 0; e < array54.Length; e++)
                {
                    norepes[r] = Array.BinarySearch(array54, array54[e]);
                }
            }

            Console.WriteLine("Números en el array no repetidos: ");
            for (int e = 0; e < array54.Length; e++)
            {
                if (norepes[e] != -1)
                {
                    Console.Write(norepes[e] + " ");
                }
            }

            //Ejercicio 55
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            int vidas = 6;
            int[,] array55 = new int[5, 5];
            int restantes = 3;
            bool fin = false;

            for (int eo = 0;eo < array55.Length;eo++)
            {
                for (int ns = 0; ns < array55.Length; ns++)
                {
                    array55[eo, ns] = rnd.Next(1, 20);
                }
            }

            for (int e = 0; e < 3; e++)
            {
                array55[rnd.Next(0, array55.Length - 1), rnd.Next(0, array55.Length - 1)] = 0;
            }

            do
            {
                Console.Write("Inserte una posición horizontal: ");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserte una posición vertical: ");
                int v = Convert.ToInt32(Console.ReadLine());

                if (array55[h, v] == 0)
                {
                    restantes -= 1;
                    Console.WriteLine($"¡Bien! Ha encontrado un 0. Le quedan {restantes} ceros por encontrar.");
                }
                else
                {
                    vidas -= 1;
                    Console.WriteLine($"¡Vaya...! Ha fallado. Eso le resta una vida. Le quedan {vidas} vidas.");
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Fin del juego...");
                }
                else
                {
                    Console.WriteLine("¡Ánimo, que aún le quedan vidas!");
                }

                if (restantes == 0 && vidas != 0)
                {
                    Console.WriteLine("¡Enhorabuena!¡Ha ganado!");
                }

                if (restantes == 0 || vidas == 0)
                {
                    fin = true;
                }
                else
                {
                    fin = false;
                }
            }while (fin == false);

            //Ejercicio 56
            Console.ReadLine();
            Console.Clear();
            Console.Title = "Ejercicio " + ejercicio;
            Console.WriteLine("Ejercicio " + ejercicio);
            ejercicio += 1;

            vidas = 6;
            int[,] array56 = new int[5, 5];
            restantes = 3;
            fin = false;

            for (int eo = 0; eo < array55.Length; eo++)
            {
                for (int ns = 0; ns < array55.Length; ns++)
                {
                    array55[eo, ns] = rnd.Next(1, 20);
                }
            }

            for (int e = 0; e < 3; e++)
            {
                array55[rnd.Next(0, array55.Length - 1), rnd.Next(0, array55.Length - 1)] = 0;
            }

            do
            {
                Console.Write("Inserte una posición horizontal: ");
                int h = Convert.ToInt32(Console.ReadLine());
                Console.Write("Inserte una posición vertical: ");
                int v = Convert.ToInt32(Console.ReadLine());

                if (array55[h, v] == 0)
                {
                    restantes -= 1;
                    Console.WriteLine($"¡Tocado y hundido! Le quedan {restantes} barcos.");
                }
                else
                {
                    vidas -= 1;
                    Console.WriteLine($"¡Agua! Le quedan {vidas} intentos.");
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Fin del juego...");
                }
                else
                {
                    Console.WriteLine("¡Ánimo, que aún le quedan intentos!");
                }

                if (restantes == 0 && vidas != 0)
                {
                    Console.WriteLine("¡Enhorabuena!¡Ha ganado!");
                }

                if (restantes == 0 || vidas == 0)
                {
                    fin = true;
                }
                else
                {
                    fin = false;
                }
            } while (fin == false);

            Console.ReadLine();
        }
    }
}

    

