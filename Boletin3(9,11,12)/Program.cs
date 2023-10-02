using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin3_9_11_12_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 9";
            int x, y, vx, vy;
            Console.WriteLine("Introduzca el valor de x: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de y: ");
            y = int.Parse(Console.ReadLine());
            vx = x;
            vy = y;
            Console.WriteLine("Valores originales: x = {0}, y = {1}", x, y);
            x = vy;
            y = vx;
            Console.WriteLine("Valores intercambiados: x = {0}, y = {1}", x, y);
            Console.ReadLine();
            
            Console.Clear();
                        
            Console.Title = "Ejercicio 11";
            double velocidad, espacio, tiempo;
            Console.WriteLine("Inserte una cantidad de espacio en metros:");
            espacio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Inserte una cantidad de tiempo en segundos:");
            tiempo = Convert.ToDouble(Console.ReadLine());
            velocidad = espacio / tiempo;
            Console.WriteLine($"La velocidad es {velocidad} metros/segundo");
            Console.ReadLine();

            Console.Clear();

            Console.Title = "Ejercicio 12";
            int lado;
            double p, d, A;
            Console.WriteLine("Inserte la medida del lado del cuadrado:");
            lado = Convert.ToInt32(Console.ReadLine());
            p = 4 * lado;
            d = Math.Sqrt(d: 2);
            A = Math.Pow(lado, 2);
            Console.WriteLine($"Perímetro = {p}, diámetro = {d} y área = {A}");
            Console.ReadLine();
        }
    }
}
