using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios4a8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ejercicio = 0;

            Console.WriteLine("Introducir ejercicio (4 a 8, no te pases)");
            ejercicio = int.Parse(Console.ReadLine());

            if(ejercicio == 4)
            {
                double media, nota1, nota2, nota3;
                Console.WriteLine("Inserta la primera nota");
                nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserta la segunda nota");
                nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Inserta la tercera nota");
                nota3 = double.Parse(Console.ReadLine());
                media = (nota1 + nota2 + nota3) / 3;
                if (media >= 5)
                {
                    Console.WriteLine($"Has sacado de media un {media}, por lo tanto has aprobado.");
                }
                else
                {
                    Console.WriteLine($"Has sacado de media un {media}, por lo tanto suspendiste.");
                }
            }
        }
    }
}
