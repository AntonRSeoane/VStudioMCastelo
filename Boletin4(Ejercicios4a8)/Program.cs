using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            else if(ejercicio == 5)
            {
                double num1, num2, suma;
                Console.WriteLine("Di un número");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Di otro número");
                num2 = Convert.ToDouble(Console.ReadLine());
                suma = num1 + num2;
                if (suma >= 0)
                {
                    Console.WriteLine($"La raíz cuadrada de la suma de {num1} y {num2} es {Math.Sqrt(suma)}");
                }
                else
                {
                    Console.WriteLine($"La raíz cuadrada de la suma de {num1} y {num2} no se puede calcular, ya que es negativa. Para más información, acuda a https://boulderbugle.com/informacion-acerca-de-errores-ne7tjrqr");
                }
            }
            else if (ejercicio == 6)
            {
                string contrasena = "abc123##", contrasenaSolicitada;
                Console.WriteLine("Para acceder, inserte la contraseña");
                Console.Write("Contraseña: ");
                contrasenaSolicitada = Console.ReadLine();
                if (contrasenaSolicitada != contrasena)
                {
                    Console.WriteLine("Esa contraseña es incorrecta");
                }
                else
                {
                    Console.WriteLine("Iniciando sesión...");
                }
            }
            else if(ejercicio == 7)
            {
                double num1, num2;
                Console.WriteLine("Escriba un número");
                Console.Write("Número = ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escriba otro número");
                Console.Write("Número = ");
                num2 = Convert.ToDouble(Console.ReadLine());
                if (num1 > num2)
                {
                    Console.WriteLine($"{num1} elevado a {num2} es {Math.Pow(num1, num2)}");
                }
                else
                {
                    Console.WriteLine($"{num2} elevado a {num1} es {Math.Pow(num2, num1)}");
                }
            }
            else if(ejercicio == 8)
            {
                Random presionx = new Random();
                Random temperaturax = new Random();
                double presion = presionx.Next(1, 3); double temperatura = temperaturax.Next(400, 600);
                Console.WriteLine($"Temperatura = {temperatura} Kelvin; presión = {presion} atmósfera(s)");
                if (presion > 2)
                {
                    Console.WriteLine("Abrir válvula de seguridad");
                    Console.Beep(432, 1000);
                    Console.Beep(528, 1000);
                }
                
                if (temperatura > 500)
                {
                    Console.WriteLine("Reducir la temperatura");
                    Console.Beep(432, 1000);
                    Console.Beep(528, 1000);
                }
                else
                {
                    Console.WriteLine("Todo en orden");
                }
            }
            else
            {
                Console.WriteLine($"El ejercicio {ejercicio} no existe");
            }
            
            
            
            Console.ReadLine();
        }
    }
}
