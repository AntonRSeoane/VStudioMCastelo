﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 7
            
            // Solicitar el valor de n al usuario
            Console.Write("Ingrese el valor de n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Crear un array con capacidad para n valores de tipo int
            int[] array1 = new int[n];

            // Darle valor a la primera y última posición
            array1[0] = 10; // Valor de la primera posición
            array1[n - 1] = 20; // Valor de la última posición

            //Ejercicio 8

            // Crear un array con capacidad para 100 valores de tipo int
            int[] array2 = new int[100];

            // Darle valores aleatorios entre 0 y 10 a todas las posiciones
            Random random = new Random();
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 11);
            }

            //Ejercicio 9

            // Crear un array con capacidad para 100 valores de tipo int
            int[] array3 = new int[100];

            // Guardar en las posiciones pares los valores: 1, 2, 3, 4, ...
            /*for (int i = 0; i < array3.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array3[i] = i / 2 + 1;
                }
            }*/
            for (int i = 0; i < array3.Length; i += 2)
            {
                array3[i] = (i / 2) + 1;
            }

            // Crear un array con capacidad para 100 valores de tipo int
            int[] array4 = new int[100];

            // Modificar todas las posiciones impares con números aleatorios entre 10 y 35
            for (int i = 0; i < array4.Length; i++)
            {
                if (i % 2 != 0)
                {
                    array4[i] = random.Next(10, 36);
                }
            }



            // Imprimir los arrays
            Console.WriteLine("******EJERCICIO 7******");
            Console.WriteLine("Array 1:");
            ImprimirArray(array1);

            Console.WriteLine("******EJERCICIO 8******");
            Console.WriteLine("Array 2:");
            ImprimirArray(array2);

            Console.WriteLine("******EJERCICIO 9******");
            Console.WriteLine("Array 3:");
            ImprimirArray(array3);

            Console.WriteLine("******EJERCICIO 10******");
            Console.WriteLine("Array 4:");
            ImprimirArray(array4);

            //Ejercicio 8

            int[] array = new int[100];

            Random random2 = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 11);
            }

            //Ejercicio 9

            for (int i = 0; i < array.Length; i += 2)
            {
                array[i] = (i / 2) + 1;
            }

            //Ejercicio 10

            for (int i = 1; i < array.Length; i += 2)
            {
                array[i] = random.Next(10, 35);
            }
            Console.ReadLine();
        }


        // Método para imprimir un array
        public static void ImprimirArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    }

