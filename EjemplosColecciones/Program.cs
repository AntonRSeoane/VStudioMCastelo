using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosColecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> dic = new Dictionary<String, String>();

            //añadir pareja clave - valor
            dic.Add("12345678S", "Pedro Martínez");
            dic.Add("98989898W", "Martín Gutiérrez");
            dic.Add("11111111S", "Lucía Sánchez");

            //Búsqueda por clave
            string personaBuscada = dic["12345678S"];
            Console.WriteLine(personaBuscada);

            //Recorrer claves
            Console.WriteLine();
            Console.WriteLine("\nClaves almacenadas actualmente: ");
            foreach (string key in dic.Keys)
            {
                Console.WriteLine(dic[key]);
            }

            //Recorrer valores
            Console.WriteLine("\nLos valores son:");

            foreach(string value in dic.Values)
            {
                Console.WriteLine(value);
            }

            //Mostrar claves y valores

            foreach(string key in dic.Keys)
            {
                Console.WriteLine(key + " " + dic[key]);
            }


            //Otra opción
            foreach(KeyValuePair<string,string> pair in dic)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }

            //Excepciones:
            //Al buscar valor inexistente
            string persona2;
            Boolean encontrado = dic.TryGetValue("1214",out persona2);
            Console.WriteLine(persona2);
            if (encontrado)
            {
                Console.WriteLine(persona2);
            }

            //Cuando metemos una clave repetida
            try
            {
                dic.Add("12345678S", "Prueba");
            }
            catch (Exception ex)
            {
                Console.WriteLine("¡Clave repetida!");
            }
            Console.Write("Introduzca DNI: ");
            string dni = Console.ReadLine();
            Console.Write("\nIntroduzca nombre y apellidos: ");
            string nombre = Console.ReadLine();

            try
            {
                dic.Add(dni, nombre);
                dic.Add(dni, nombre);
            }
            catch(Exception e)
            {
                Console.WriteLine("¡La clave ya existe!");
            }

            Console.ReadLine();
        }
    }
}
