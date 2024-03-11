using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema8Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Listas
            List<int> list = new List<int>();
            //Consultar capacidad
            Console.WriteLine("Capacidad inicial: " + list.Capacity);

            //Insertar elementos
            list.Add(3);
            list.Add(9);
            list.Add(7);
            list.Add(4);
            list.Add(4);
            Console.WriteLine("Capacidad después de 2 inserts: " + list.Capacity);

            //Consultar cuantos elementos tengo
            Console.WriteLine("Elementos guardados: " + list.Count);

            //Insertar elemento en determinada posición
            list.Insert(0, 2);

            //Recuperar elemento:
            int primerElemento = list[0];

            Boolean encontrado = list.Contains(5);

            Console.WriteLine("Lista original: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            list.RemoveAt(0);

            list.Remove(4);

            Console.WriteLine("Lista de elementos después de eliminaciones: ");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }
            
            for (int i = 0; i<list.Count;i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();

            list.RemoveAll(x => x == 4);
            Console.ReadLine();

            //Conjuntos
            //No admite duplicados, y el orden no es importante.

            HashSet<string> dnis = new HashSet<string>();
            dnis.Add("12345678A");
            dnis.Add("87654321B");
            dnis.Add("98989898C");

            //Métodos comunes con listas

            encontrado = dnis.Contains("12345678A");

            foreach (string i in dnis)
            {
                Console.WriteLine(i);
            }

            SortedSet<int> enteros = new SortedSet<int>();

            Random gen = new Random();
            for (int i = 0; i <20;i++)
            {
                enteros.Add(gen.Next(1, 5));
            }

            foreach(int i in enteros)
            {
                Console.Write(i + " ");
            }

            

            Console.ReadLine();
        }
    }
}
