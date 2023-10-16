using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosApuntes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operaciones y sentencias

            //Programa que dice si has suspendido o aprobado
            Console.Title = "Detector de aprobados y suspensos";
            
            double nota, notaMax, aprobado;

            Console.Clear();
            Console.WriteLine("¿Cuál es la máxima nota posible?");
            Console.Write("Tú: ");
            notaMax = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("¿Qué nota has sacado?");
            Console.Write("Tú: ");
            nota = Convert.ToDouble(Console.ReadLine());
            aprobado = notaMax / 2;
            if (nota >= aprobado)
            {
                Console.WriteLine("¡Enhorabuena! Eso significa que has aprobado =)");
            }
            else
            {
                Console.WriteLine("¡Ups! Me temo que no has aprobado. No te preocupes, ¿quién dijo que sería fácil?");
            }
            Console.ReadLine();
            Console.Clear();

            //Programa para distinguir números positivos de negativos
            Console.Title = "¿Positivo o negativo?";

            Console.WriteLine("Pon un número");
            Console.Write("Tú: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero >= 0)
            {
                Console.WriteLine("Es positivo");
            }
            else 
            {
                Console.WriteLine("Es negativo o 0");
            }
            Console.ReadLine() ;

            //Arte ASCII
            Console.Clear();
            Console.WriteLine("                          @");
            Console.WriteLine(" @@@@@@            @     @           ");
            Console.WriteLine("@      @  @ @@@@  @@@   @@@@  @ @@@@");
            Console.WriteLine("@@@@@@@@  @@    @  @   @    @ @@    @");
            Console.WriteLine("@      @  @     @  @   @    @ @     @");
            Console.WriteLine("@      @  @     @  @    @@@@  @     @");
            Console.WriteLine("                    @   @");
            Console.WriteLine("                     @@@");
            Task.Delay(1000).Wait();
            Console.WriteLine("No te olvides de seguirme en GitHub: https://www.github.com/AntonRSeoane");
            Console.ReadLine();
        }
    }
}
