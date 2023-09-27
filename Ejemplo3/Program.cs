using System;

class Program
{
    static void Main(string[] args)
    {
        //Ejercicio 8
        Console.Title = "Pirámide de asteriscos";
        Console.WriteLine("   *   ");
        Console.WriteLine(" *   * ");
        Console.WriteLine("*  *   *");
        Console.ReadLine();
        Console.Clear();
        
        //Cambio al ejercicio 9 al pulsar enter
        Console.Title = "Nombre con asteriscos";
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ******                           *");
        Console.WriteLine("*      *                         *");
        Console.WriteLine("********    ******    *****    ****    ******");
        Console.WriteLine("*      *    *     *     *     *    *   *     *");
        Console.WriteLine("*      *    *     *     *      ****    *     *");
        Console.ReadLine();

        Console.Title = "Gracias";
        Console.Clear();
        Console.WriteLine("(* _ *)");
        System.Threading.Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine("(* v *)");
        System.Threading.Thread.Sleep(250);
        Console.Clear();
        Console.WriteLine("(* V *)");
        System.Threading.Thread.Sleep(250);
        Console.Clear();
        Console.WriteLine("(^ V ^)");
        Console.ReadLine();
    }
}
