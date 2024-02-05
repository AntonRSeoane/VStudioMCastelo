using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConexionFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = Directory.GetCurrentDirectory();
            string rutaFichero = ruta + @"\series.txt";
            Console.WriteLine("Ruta actual: " + rutaFichero);

            StreamWriter escritor = new StreamWriter(rutaFichero, false);

            escritor.WriteLine("Death Note*Crunchyroll");

            escritor.Close();

            StreamReader lector = new StreamReader(rutaFichero);


            Console.ReadLine();
        }
    }
}
