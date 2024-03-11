using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin8
{
    class Program
    {
        static List<string> tareasPendientes = new List<string>();
        static List<string> tareasCompletadas = new List<string>();
        static void Main(string[] args)
        {
            Console.Write("Ejercicio: ");
            int ej = Convert.ToInt32(Console.ReadLine());
            if (ej == 1)
            {
                Random random = new Random();
                List<int> numeros = new List<int>();

                for (int i = 0; i < 10; i++)
                {
                    int randomNumber = random.Next(1, 26);
                    numeros.Add(randomNumber);
                }

                //b)
                int sum = numeros.Sum();
                Console.WriteLine($"\nLa suma de los valores generados es: {sum}");

                //c)
                double media = (double)sum / numeros.Count;
                Console.WriteLine($"La media de los valores generados es: {media}");

                //d)
                int contMas20 = numeros.Count(n => n > 20);
                Console.WriteLine($"El porcentaje de números superiores a 20 es: {(double)contMas20 / numeros.Count * 100}%");

                //e)
                IEnumerable<int> dNum = numeros.Distinct();
                Console.WriteLine("\nLos valores que están almacenados, sin mostrar las repeticiones, son:");

                foreach (int num in dNum)
                {
                    Console.WriteLine(num);
                }
            }
            else if (ej == 2)
            {
                MostrarMenu();

                int opcion = ObtenerOpcion();

                switch (opcion)
                {
                    case 1:
                        IntroducirTarea();
                        break;
                    case 2:
                        CompletarTarea();
                        break;
                    case 3:
                        ContarTareasPendientes();
                        break;
                    case 4:
                        MostrarTareasPendientes();
                        break;
                    case 5:
                        MostrarTareasCompletadas();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;
                }
            }
            else if (ej == 3)
            {
                bool rep = false;
                Console.WriteLine(@"______ ___________  _____  _____ _   _   ___   _____  ______ _   _ _____ _____   ___ ______  ___   _____ 
| ___ \  ___| ___ \/  ___||  _  | \ | | / _ \ /  ___| | ___ \ | | /  ___/  __ \ / _ \|  _  \/ _ \ /  ___|
| |_/ / |__ | |_/ /\ `--. | | | |  \| |/ /_\ \\ `--.  | |_/ / | | \ `--.| /  \// /_\ \ | | / /_\ \\ `--. 
|  __/|  __||    /  `--. \| | | | . ` ||  _  | `--. \ | ___ \ | | |`--. \ |    |  _  | | | |  _  | `--. \
| |   | |___| |\ \ /\__/ /\ \_/ / |\  || | | |/\__/ / | |_/ / |_| /\__/ / \__/\| | | | |/ /| | | |/\__/ /
\_|   \____/\_| \_|\____/  \___/\_| \_/\_| |_/\____/  \____/ \___/\____/ \____/\_| |_/___/ \_| |_/\____/ 
                                                                                                         
                                                                                                         
______ ___________   _       ___   ____________ _____                                                    
| ___ \  _  | ___ \ | |     / _ \  |  ___| ___ \_   _|                                                   
| |_/ / | | | |_/ / | |    / /_\ \ | |_  | |_/ / | |                                                     
|  __/| | | |    /  | |    |  _  | |  _| | ___ \ | |                                                     
| |   \ \_/ / |\ \  | |____| | | | | |   | |_/ /_| |_                                                    
\_|    \___/\_| \_| \_____/\_| |_/ \_|   \____/ \___/                                                    
                                                                                                         
                                                                                                         ");
                Dictionary<String, String> dic = new Dictionary<string, string>();
                do
                {
                    Console.WriteLine("\nElija una opción: ");
                    Console.WriteLine("     a) Guardar DNI.");
                    Console.WriteLine("     b) Eliminal DNI.");
                    Console.WriteLine("     c) Mostrar DNIs.");
                    Console.WriteLine("     d) Buscar DNI.");
                    Console.WriteLine("     e) Contar DNIs.");

                    char op = Console.ReadKey().KeyChar;
                    

                    if (op == 'a')
                    {
                        Console.Write("\nInserta DNI: ");
                        string DNI = Console.ReadLine();
                        Console.Write("\nInserta nombres y apellidos: ");
                        string nombreAplldos = Console.ReadLine();

                        try
                        {
                            dic.Add(DNI, nombreAplldos);
                        }
                        catch
                        {
                            Console.WriteLine("Esa persona ya está en la lista.");
                        }

                    }
                    else if (op == 'b')
                    {
                        Console.Write("\nInserta DNI a quitar: ");
                        string DNI = Console.ReadLine();
                        dic.Remove(DNI);
                    }
                    else if (op == 'c')
                    {
                        foreach (var key in dic)
                        {
                            Console.WriteLine(key);
                        }
                    }
                    else if (op == 'd')
                    {
                        Console.Write("\nInserta DNI a buscar: ");
                        string DNI = Console.ReadLine();
                        Console.Write("\nInserta nombre y apellidos a buscar: ");
                        string nombreApllds = Console.ReadLine();
                        bool encontrar = dic.ContainsKey(DNI);
                        switch (encontrar) {
                            case true:
                                Console.WriteLine($"Se ha encontrado el DNI {DNI}.");
                                break;
                            case false:
                                Console.WriteLine("DNI no encontrado.");
                                break;
                        }
                    }
                    else if (op == 'e')
                    {
                        Console.WriteLine("Número de DNIs registrados: " + dic.Count);
                    }
                    else
                    {

                    }

                    Console.Write("¿Ver otra opción?(S/N)");
                    char siono = Console.ReadKey().KeyChar;

                    if (siono == 's')
                    {
                        rep = true;
                    }
                    else
                    {
                        rep = false;
                    }
                } while (rep == true);
                
            }
            else if (ej == 666)
            {
                Console.Clear();
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
        static void MostrarMenu()
        {
            Console.WriteLine("\n---- Aplicación de Tareas ----");
            Console.WriteLine("1. Introducir Tarea");
            Console.WriteLine("2. Completar Tarea");
            Console.WriteLine("3. Contar Tareas Pendientes");
            Console.WriteLine("4. Mostrar Tareas Pendientes");
            Console.WriteLine("5. Mostrar Tareas Completadas");
            Console.WriteLine("6. Salir");
        }

        static int ObtenerOpcion()
        {
            Console.Write("Seleccione una opción: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static void IntroducirTarea()
        {
            Console.Write("Introduzca la tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareasPendientes.Add(nuevaTarea);
            Console.WriteLine("Tarea añadida correctamente.");
        }

        static void CompletarTarea()
        {
            if (tareasPendientes.Count > 0)
            {
                Console.WriteLine("Tareas Pendientes:");
                MostrarTareasPendientes();

                Console.Write("Seleccione el número de la tarea a completar: ");
                int indice = Convert.ToInt32(Console.ReadLine()) - 1;

                if (indice >= 0 && indice < tareasPendientes.Count)
                {
                    string tareaCompletada = tareasPendientes[indice];
                    tareasPendientes.RemoveAt(indice);
                    tareasCompletadas.Add(tareaCompletada);
                    Console.WriteLine("Tarea completada y movida a la lista de tareas completadas.");
                }
                else
                {
                    Console.WriteLine("Número de tarea no válido.");
                }
            }
            else
            {
                Console.WriteLine("No hay tareas pendientes para completar.");
            }
        }

        static void ContarTareasPendientes()
        {
            Console.WriteLine($"Número de tareas pendientes: {tareasPendientes.Count}");
        }

        static void MostrarTareasPendientes()
        {
            if (tareasPendientes.Count > 0)
            {
                Console.WriteLine("\nTareas Pendientes:");
                for (int i = 0; i < tareasPendientes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareasPendientes[i]}");
                }
            }
            else
            {
                Console.WriteLine("No hay tareas pendientes.");
            }
        }

        static void MostrarTareasCompletadas()
        {
            if (tareasCompletadas.Count > 0)
            {
                Console.WriteLine("\nTareas Completadas:");
                foreach (var tarea in tareasCompletadas)
                {
                    Console.WriteLine(tarea);
                }
            }
            else
            {
                Console.WriteLine("No hay tareas completadas.");
            }
        }
    }
}
