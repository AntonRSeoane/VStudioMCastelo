using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            double PI = 3.141516;
            double radio;

            Console.WriteLine("Inserte el radio:");
            radio = Convert.ToDouble(Console.ReadLine());
            
            double Longitud = 2 * PI * radio;
            double Area = PI * (radio * radio);
            double Volumen = (4 / 3) * PI * (radio * radio * radio);

            Console.WriteLine($"Longitud = {Longitud}, Área = {Area}, Volumen = {Volumen}");
            Console.ReadLine();
            //Ejercicio 5
            double precio;
            short cantidad;
            double calculo;
            Console.WriteLine("Precio:");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Cantidad: ");
            cantidad = Convert.ToByte(Console.ReadLine());
            calculo = precio * cantidad;
            Console.WriteLine($"El precio es {precio} euro(s) y la cantidad de unidades compradas es {cantidad}, por lo tanto cuesta en total {calculo} euro(s).");
            Console.ReadLine();
            //Ejercicio 7
            Console.Write("Ingrese la temperatura en grados Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 9 / 5 + 32;

            Console.WriteLine($"La temperatura equivalente en grados Fahrenheit es: {fahrenheit}");
            Console.ReadLine();
        }
    }
}
