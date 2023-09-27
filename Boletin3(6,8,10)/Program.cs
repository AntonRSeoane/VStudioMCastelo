using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin3_6_8_10_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 6";
            int suma, resta, multiplicación, valor1, valor2;

            Console.WriteLine("Inserte el primer número:");
            valor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserte el segundo número:");
            valor2 = Convert.ToInt32(Console.ReadLine());
            suma = valor1 + valor2;
            resta = valor1 - valor2;
            multiplicación = valor1 * valor2;
            Console.WriteLine($"Suma = {suma}");
            Console.WriteLine($"Resta = {resta}");
            Console.WriteLine($"Multiplicación = {multiplicación}");
            Console.ReadLine();

            Console.Clear();

            Console.Title = "Ejercicio 8";
            double p, v, n, t, r;
            r = 0.082;
            Console.WriteLine($"Inserte el volumen:");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Inserte el número de moles:");
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Inserte la temperatura:");
            t = Convert.ToDouble(Console.ReadLine());
            p = (n * r * t) / v;
            Console.WriteLine($"Con un volumen de {v} litros, y una temperatura de {t} kelvin, {n} moles de un gas ideal tienen una presión de {p} atmósferas");
            Console.ReadLine();

            Console.Clear();

            Console.Title = "Ejercicio 10";

            Console.WriteLine("Introduzca las horas trabajadas: ");
            double horasTrabajadas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca la tasa por hora: ");
            double tasaPorHora = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Introduzca el IRPF: ");
            double irpf = Convert.ToDouble(Console.ReadLine());
            double salarioBruto = (horasTrabajadas * tasaPorHora);
            double salarioNeto = (salarioBruto - irpf);

            Console.WriteLine($"Salario bruto: {salarioBruto}");
            Console.WriteLine($"Salario neto: {salarioNeto}");
            Console.ReadLine();

    }
    }
}
