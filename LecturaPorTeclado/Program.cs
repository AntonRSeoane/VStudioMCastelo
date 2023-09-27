using System;

namespace LecturaPorTeclado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que solicita DNI y Edad y salario
            string DNI, nombre;
            byte Edad;
            float Salario;

            //Cambio de título de ventana
            Console.Title = "Programa fachero de lectura por teclado";

            //Programa
            Console.WriteLine("¿Cuál es su nombre?");
            nombre = Console.ReadLine();
            
            Console.WriteLine($"{nombre}, inserte su DNI:");
            DNI = Console.ReadLine();

            Console.WriteLine($"{nombre}, inserte su edad:");
            Edad = byte.Parse(Console.ReadLine());

            Console.WriteLine($"{nombre}, inserte su salario:");
            Salario = float.Parse(Console.ReadLine());
            Convert.ToSingle(Salario);
            
            Console.WriteLine($"Tiene usted {Edad} años de edad y su DNI ({DNI}) lo confirma. Su salario es {Salario} euros.");
            Console.ReadLine();


        }
    }
}

