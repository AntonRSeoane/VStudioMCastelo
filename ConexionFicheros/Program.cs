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
            escritor.WriteLine("Los Simpson*Netflix");
            escritor.Close();

            StreamReader lector = new StreamReader(rutaFichero);


            Console.ReadLine();

            String ruta2 = Directory.GetCurrentDirectory();
            String rutaFichero2 = ruta + "\\series2.txt";
            //Recuperar datos del fichero
            String[] series = new string[100];

            StreamReader lector2;
            try
            {
                lector2 = new StreamReader(rutaFichero2);
                int pos = 0;
                String registro = "";
                while (registro != null)
                {
                    registro = lector2.ReadLine();
                    series[pos] = registro;
                    pos++;
                }
                lector2.Close();
            } catch (IOException e)
            {
                //Console.WriteLine("El fichero no existe");
                if (!File.Exists(rutaFichero2))
                {
                    File.Create(rutaFichero2);
                }
                lector2 = new StreamReader(rutaFichero2);
                int pos = 0;
                String registro = "";
                while (registro != null)
                {
                    registro = lector2.ReadLine();
                    series[pos] = registro;
                    pos++;
                }
                lector2.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadLine();

            int opcion = 0;
            
            do
            {
                Console.WriteLine("Elige opción:");
                Console.WriteLine("1. Nueva serie");
                Console.WriteLine("2. Catálogo");
                Console.WriteLine("3. Buscar serie");
                Console.WriteLine("4. Ver serie por plataforma");
                Console.WriteLine("5. Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Título: ");
                        String titulo = Console.ReadLine();
                        Console.Write("\nPlataforma: ");
                        String plataforma = Console.ReadLine();

                        StreamWriter escritor3 = new StreamWriter(rutaFichero2);
                        escritor3.WriteLine(titulo + "*" + plataforma);
                        escritor3.Close();

                        for (int i = 0; i < series.Length; i++)
                        {
                            if (series[i] == null)
                            {
                                series[i] = titulo + "*" + plataforma;
                                break;
                            }
                        }
                        break;
                    case 2:
                        foreach (String s in series)
                        {
                            if (s != null)
                            {
                                Console.WriteLine(s);
                            }
                            else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        //Buscar serie
                        Console.Write("Serie a buscar: ");
                        string buscar = Console.ReadLine();
                        
                        foreach(String s in series)
                        {
                            if (s == null)
                            {
                                Console.WriteLine("Serie no encontrada.");
                                break;
                            }

                            String[] trozos = s.Split('*');
                            if (buscar.Equals(trozos[0],StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine("Serie encontrada. Información: ");
                                Console.WriteLine("Plataforma: " + trozos[1]);
                                break;
                            }
                                                        
                        }
                        
                        break;
                    case 4:
                        break;
                    default:
                        break;
                }
            } while (opcion != 5);
            
            
            Console.ReadLine();


        }
    }
}
