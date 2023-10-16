using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesYSentencias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salario, irpf, calculo;
            Console.WriteLine("Escriba el salario bruto: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario <= 1200)
            {
                irpf = 15;
            }
            else
            {
                irpf = 19;
            }
            
            
            calculo = (irpf * 100 / salario);
            Console.WriteLine($"Salario neto = {calculo}");
            Console.ReadLine();

            //Programa que clasifica número como negativo, cero o positivo
            int numero = 900;

            if( numero < 0)
            {
                Console.WriteLine("Número negativo");
            }
            else if( numero == 0)
            {
                Console.WriteLine("Número es cero");
            }
            else
            {
                Console.WriteLine("Número positivo");
            }
            Console.ReadLine();
        }
    }
}
