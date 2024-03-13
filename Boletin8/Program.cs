using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletin8
{
    class Program
    {
        static Dictionary<string, List<string>> clientela = new Dictionary<string, List<string>>();
        static Dictionary<string, string> productos = new Dictionary<string, string>();

        static List<string> tareasPendientes = new List<string>();
        static List<string> tareasCompletadas = new List<string>();
        static Dictionary<int, Cliente> clientes = new Dictionary<int, Cliente>();
        static Dictionary<string, string> estados = new Dictionary<string, string>()
    {
        {"Alabama", "Montgomery"},
        {"Alaska", "Juneau"},
        {"Arizona", "Phoenix"},
        {"Arkansas", "Little Rock"},
        {"California", "Sacramento"},
        {"Colorado", "Denver"},
        {"Connecticut", "Hartford"},
        {"Delaware", "Dover"},
        {"Florida", "Tallahassee"},
        {"Georgia", "Atlanta"},
        {"Hawaii", "Honolulu"},
        {"Idaho", "Boise"},
        {"Illinois", "Springfield"},
        {"Indiana", "Indianapolis"},
        {"Iowa", "Des Moines"}
    };
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
            else if (ej == 4)
            {

                bool rep = false;
                do
                {
                    Console.WriteLine("\nElija una opción: ");
                    Console.WriteLine("1. Ver todos los estados junto con su capital");
                    Console.WriteLine("2. Buscar la capital de un estado en concreto");
                    Console.WriteLine("3. Mostrar el estado al que pertenece una determinada capital");
                    Console.WriteLine("4. Introducir un nuevo estado con su capital");
                    Console.WriteLine("5. Mostrar los estados ordenados alfabéticamente");
                    Console.WriteLine("6. Eliminar un determinado estado junto con su capital");

                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            MostrarEstados();
                            break;
                        case 2:
                            BuscarCapitalPorEstado();
                            break;
                        case 3:
                            BuscarEstadoPorCapital();
                            break;
                        case 4:
                            AgregarEstado();
                            break;
                        case 5:
                            MostrarEstadosOrdenados();
                            break;
                        case 6:
                            EliminarEstado();
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
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
            else if (ej == 5)
            {
                bool continuar = true;
                while (continuar)
                {
                    Console.WriteLine("1. Guardar cliente");
                    Console.WriteLine("2. Mostrar clientes");
                    Console.WriteLine("3. Buscar cliente");
                    Console.WriteLine("4. Eliminar cliente");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");



                    int opcion;
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out opcion))
                    {
                        if (opcion == 1)
                        {
                            Console.Write("Ingrese el DNI del cliente: ");
                            string dni = Console.ReadLine();
                            Console.Write("Ingrese el nombre del cliente: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese la edad del cliente: ");
                            int edad = int.Parse(Console.ReadLine());
                            Console.Write("Ingrese el correo electrónico del cliente: ");
                            string correo = Console.ReadLine();

                            Console.Write("Asigne una clave al cliente: ");
                            int clave = int.Parse(Console.ReadLine());

                            Cliente cliente = new Cliente(dni, nombre, edad, correo);
                            clientes.Add(clave, cliente);
                            Console.WriteLine("Cliente guardado exitosamente.");
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("Lista de clientes:");
                            foreach (var kvp in clientes)
                            {
                                Console.WriteLine($"Clave: {kvp.Key}, DNI: {kvp.Value.DNI}, Nombre: {kvp.Value.Nombre}, Edad: {kvp.Value.Edad}, Correo electrónico: {kvp.Value.Correo}");
                            }
                        }
                        else if (opcion == 3)
                        {
                            Console.Write("Ingrese la clave del cliente que desea buscar: ");
                            int clave = int.Parse(Console.ReadLine());

                            if (clientes.ContainsKey(clave))
                            {
                                Cliente cliente = clientes[clave];
                                Console.WriteLine($"Clave: {clave}, DNI: {cliente.DNI}, Nombre: {cliente.Nombre}, Edad: {cliente.Edad}, Correo electrónico: {cliente.Correo}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró ningún cliente con esa clave.");
                            }
                        }
                        else if (opcion == 4)
                        {
                            Console.Write("Ingrese la clave del cliente que desea eliminar: ");
                            int clave = int.Parse(Console.ReadLine());

                            if (clientes.ContainsKey(clave))
                            {
                                clientes.Remove(clave);
                                Console.WriteLine("Cliente eliminado exitosamente.");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró ningún cliente con esa clave.");
                            }
                        }
                        else if (opcion == 5)
                        {
                            continuar = false;
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Por favor, introduzca un número válido.");
                    }

                    Console.WriteLine();
                }
            }
            else if (ej == 6)
            {
                Program programa = new Program();
                programa.Run();
            }
            else if (ej == 666)
            {
                Console.Clear();
                Console.WriteLine(@"
                                      .:^!7?JYY555PPPPPPPPPPP555YJJ7!~:.                            
                                .^7JY555YYJ??7!!!~~~~~~~~~~~~~!!!7?JJY555Y?!^.                      
                            :!J5P5J?!~~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!?Y5P5?^                   
                         ^JPPY?~^:::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!JPP?:                
                      .?PPJ!^:::....:^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^!YG5^              
                    .JB5!^^::.....::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~JBY             
                   7B5~^^^:....::^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~GG:           
                 .5B7^^^:.....:^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~J~^^^^^^^^^^^^^^^^PB.          
                .GG~^^^^:...:^^^^^^^^^^~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^75~^^^^^^^^^^^^^^^~#Y          
                GG^^^^^^^^^^^^^^^^^^^^~JJ!^^^^^^^^^^^^^^^^^^^^^^^^^^^^JJ^^^^^^^^^^^^^^^^J&:         
               J&~^^^^^^^^^^^^^^^^^^^^^^!JJ~^^^^^^^^^^^^^^^^^^^^^^^^^^~P^^^^^^^^^^^^^^^^!@!         
              :&J^^^^^^^^^^^^^^^^^^^^^^^^^75~^^^^^^^^^^^^^^^^^^^^^^!7^~5~^~J^^^^^^^^^^^^~&?         
              ?&~^^^^^^^^^^^^^^^^^^^^^^^^^^?Y^^^^^^^^^^^^^^^^^^^^^^~57^~^^57^^^^^^^^^^^^^BP         
              PG^^^^^^^^^^^^^^^^^^^^^^^^^^~Y?^^^^^^^^^^^^^^^^^^^^^^^!P~^^JJ^^^^^^^^^^^^^^?#J:       
              B5^^^^^^^^^^^^^^^^^^^^^^^^~JJ!^^^^^^^^^^^^^^^^^^^^^^^^^YJ^~P~^^^^^^^^^^^^^^^~Y#!      
              #5^^^^^^^^^^^^^^^^^^^^^^^~5!^^^^^^^^^^^^^^^^^^^^^~^^^^^YJ^~P~^^^^^^^^^^^^^^^^^J&^     
              GP^^^^^^^^^^^^^^^^^^^^^^^75^^^^^^^^^^^^^^^^^^^~!J7^^^^75~^^??^^~~^^^^^^^^^^^^^~@7     
              5B^^^^^^^^^^^^^^^^^^^^^^^^YJ~^^^^^^^~~~~!!!7??Y5J7!^^^!~^^~~^^~!5J!~^^^^^^^^^^Y&:     
              !@!^^^^^^^^^^^^^^^^^^^^^^^^7~^^^^^^^755?777!~^^^~!?J!^^^^^?57??77???????~^^^!PB~      
               BP^^^^^^^^^^^^^^^^^^^^^^^^^^!J7!~~^75!!777JYYYYY?7?P~^^^^P57~~!!!777!7P7^!GP?.       
               !&7^^^^^^^^^^^^^^^^^^^^^^^^^^~7?J?~JP!~~^^YGBBB5~^7G~^^^^Y5?77!5BBBBG??B?5@:         
                J&!^^^^^^^^^^^^^^^^^^^^^^^^^^7??~^~J?~::::~!!~:^7J!^^^^^^?J7:.:7JJ?~^JY?J@~         
                 Y#7^^^^^^^^^^^^^^^^^YJ^^^^^^~^^^^^^!???77!!77?J5!^^^^^^^^^?5~~~~!7??!^^~5B?        
                  7#Y^^^^^^^^^^^^^^^5#7^^^^^^^^^^^^^^^^~~~!!!7?J!^^^^^^^^^^^GYJ??7!~^^^^^^!BP       
                   ^PG?^^^^^^^^^^^^7@?^^^^^^^^^^^^^^^^^^~????7~^^^^^^^^^^^^~P!!777~^^^^^^^^?@:      
                     !PGJ~^^^^^^^^^?@!^^^^^^^^^^^^^^^^^^^~^^^^^^^^^^^^^^^^^?Y^^^^^^^^^^^^^^GG       
                       ^YG5?!^^^^^^~BG~^^^^^^^^^^^^^^^^^^^^^^^^~^^^^^^^^^^^P!^^^^^^^^^^^^!GG.       
                         .~J5P5J7!^^~PB?^^^^^^^^^^^^^^^^^^^^^757^^^^^^^^^^~G?!^^^^^^^^^!5B?         
                             :~7J5BG?^?PGY?!~~^^^^^^^^^^^^^~YG!^~^^^^^^^^^^P75!^^^^^~?PG?.          
                                 :@Y~^^^5&Y5PPPP5557^^^^^^!YB7~5JJ?~^^^^^^^?Y5?^^^~JG5!.            
                                 Y#~^^^^Y&^^^~~~!!5&!^^^^75~!7^??~7Y7^^^^^~7P?Y^^^PB:               
                                !&7^^^^^Y&~^^^^^^^7@7^^^75~^^^^^^^^~?J?????7~^5!^^#Y                
                               ~&J^^^^^^P#^^^^^^^^J@!^^~P!^^^^^^^^~!!!~~!!^^^^?Y^~#J                
                              !&J^^^^^^^BG^^^^^^^^7J^^^?Y^^^^^^^!JJ?7?JJ??Y7^^!?^~&7                
                             ?&?^^^^^^^~&J^^^^^^^^^^^^^Y?^^^^^~?J7~~77~~!7~YJ~^^^!&!                
                 ..::^~~~!!!Y#7^^^^^^^^?&!^^^^^^^^^^^^^~~^^^~JGY??JJ5Y?JY5?JG7^^^!@~                
       .:^!7JY55PPPPBBYYYJY@B!^^^^^^^^^GG^^^^^^^^^^^^^^^^^^^^~757~~~~~!~~^!P7^^^^7@~                
 :~7JYPPGPP55YYJJ??5Y~^^^7B5^^^^^^^^^^!@?^^^^^^^^^^^^^^^^^^^^^^!YJ7!!!!!!?Y7^^^^^7@^                
PGPP5YJJ?????????JPJ^^^^^??^^^^^^^^^^^Y#~^^^^^^^^^^^^^^^^^^^^^^^^!7??????7~^^^^^^7@^                
J????????????????P?^^^^^^^^^^^^^^^^^^^GG^^^^^^^^^^^^^^^^^^^^^^^^^^!?????!^^^^^^^^!@!                
????????????????PJ^^^^^^^^^^^^^^^^^^^^5#^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~^^^^^^^^~5GY7:             
???????????????JG~^^^^^^^^^^^^^^^^^^^^~BG!^^^^^^^^^^^^^^^^^^^^^^^^^~?????J?!^^^^^^^~7YB?            
???????????????5Y^^^^^^^^^^^^^^^^^^^^^^~JGPJ!^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!JJ^^^^^^^^:J&.           
???????????????5Y^^^^^^^^^^^^^^^^^^^^^^^^^7YPP5?!~^^^^^^^^^^^^^^^^^^^^^^^^^^57^^^^^^^^?@?           
???????????????YP^^^^^^^^^^^^^^^^^^^^^^^^^^^^~?YPP5Y?!~^^^^^^^^^^^^^^^^^^^^^5!^^^^~!7YGBGB!         
J???????????????P7^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!?YPPPYJ7!~^^^^^^^^^^^^^^!G??J5PGGP5Y??Y##5J!:    
BG5J????????????JP~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~!?Y5PGPYJ7!~^^~!7J5GG5PB5YYJ???????J#P5GBP7. ");
                Console.WriteLine("Epa numerín prohibido.");
            }

            Console.ReadLine();
        }


        class Cliente
        {
            public string DNI { get; }
            public string Nombre { get; }
            public int Edad { get; }
            public string Correo { get; }

            public Cliente(string dni, string nombre, int edad, string correo)
            {
                DNI = dni;
                Nombre = nombre;
                Edad = edad;
                Correo = correo;
            }
        }

        Program()
        {
            // Crear algunos productos
            CrearProductos();

            // Asociar productos a DNI
            AsociarProductos("12345678A", new List<string> { "QW34", "AB12" });
            AsociarProductos("87654321B", new List<string> { "CD56", "EF78" });
        }

        void Run()
        {
            // Menú de opciones
            while (true)
            {
                Console.WriteLine("Opciones:");
                Console.WriteLine("1. Mostrar compra de un cliente");
                Console.WriteLine("2. Eliminar un producto de la compra de un cliente");
                Console.WriteLine("3. Añadir un producto a la compra de un cliente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        MostrarCompra();
                        break;
                    case 2:
                        EliminarProducto();
                        break;
                    case 3:
                        AgregarProducto();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        void CrearProductos()
        {
            productos.Add("QW34", "Portátil HP*890€");
            productos.Add("AB12", "Teclado Logitech*50€");
            productos.Add("CD56", "Monitor Samsung*300€");
            productos.Add("EF78", "Ratón inalámbrico*20€");
        }

        void AsociarProductos(string dni, List<string> codigos)
        {
            List<string> compra = new List<string>();
            foreach (string codigo in codigos)
            {
                if (productos.ContainsKey(codigo))
                {
                    compra.Add(productos[codigo]);
                }
            }
            clientela.Add(dni, compra);
        }

        void MostrarCompra()
        {
            Console.Write("Ingrese el DNI del cliente: ");
            string dni = Console.ReadLine();

            if (clientela.ContainsKey(dni))
            {
                Console.WriteLine($"Compra del cliente con DNI {dni}:");
                foreach (string producto in clientela[dni])
                {
                    Console.WriteLine(producto);
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        void EliminarProducto()
        {
            Console.Write("Ingrese el DNI del cliente: ");
            string dni = Console.ReadLine();

            if (clientela.ContainsKey((dni)))
            {
                Console.WriteLine($"Compra del cliente con DNI {dni}:");
                int i = 1;
                foreach (string producto in clientela[dni])
                {
                    Console.WriteLine($"{i}. {producto}");
                    i++;
                }

                Console.Write("Ingrese el número del producto a eliminar: ");
                int indice = int.Parse(Console.ReadLine()) - 1;

                if (indice >= 0 && indice < clientela[dni].Count)
                {
                    clientela[dni].RemoveAt(indice);
                    Console.WriteLine("Producto eliminado correctamente.");
                }
                else
                {
                    Console.WriteLine("Número de producto no válido.");
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        void AgregarProducto()
        {
            Console.Write("Ingrese el DNI del cliente: ");
            string dni = Console.ReadLine();

            if (clientela.ContainsKey(dni))
            {
                Console.WriteLine("Productos disponibles:");
                foreach (var producto in productos)
                {
                    Console.WriteLine(producto.Value);
                }

                Console.Write("Ingrese el código del producto a añadir: ");
                string codigo = Console.ReadLine();

                if (productos.ContainsKey(codigo))
                {
                    clientela[dni].Add(productos[codigo]);
                    Console.WriteLine("Producto añadido correctamente.");
                }
                else
                {
                    Console.WriteLine("Código de producto no válido.");
                }
            }
            else
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        static void MostrarEstados()
        {
            Console.WriteLine("Estados y sus capitales:");
            foreach (var estado in estados)
            {
                Console.WriteLine($"{estado.Key}: {estado.Value}");
            }
        }

        static void BuscarCapitalPorEstado()
        {
            Console.Write("Introduzca el nombre del estado: ");
            string estado = Console.ReadLine();
            if (estados.ContainsKey(estado))
            {
                Console.WriteLine($"La capital de {estado} es {estados[estado]}.");
            }
            else
            {
                Console.WriteLine($"No se encontró el estado {estado}.");
            }
        }

        static void BuscarEstadoPorCapital()
        {
            Console.Write("Introduzca el nombre de la capital: ");
            string capital = Console.ReadLine();
            var estado = estados.FirstOrDefault(x => x.Value == capital);
            if (!estado.Equals(default(KeyValuePair<string, string>)))
            {
                Console.WriteLine($"{capital} es la capital de {estado.Key}.");
            }
            else
            {
                Console.WriteLine($"No se encontró el estado para la capital {capital}.");
            }
        }

        static void AgregarEstado()
        {
            Console.Write("Introduzca el nombre del estado: ");
            string estado = Console.ReadLine();
            Console.Write("Introduzca la capital del estado: ");
            string capital = Console.ReadLine();

            estados.Add(estado, capital);
            Console.WriteLine($"El estado {estado} con capital {capital} ha sido agregado.");
        }

        static void MostrarEstadosOrdenados()
        {
            var estadosOrdenados = estados.OrderBy(x => x.Key);
            Console.WriteLine("Estados ordenados alfabéticamente:");
            foreach (var estado in estadosOrdenados)
            {
                Console.WriteLine($"{estado.Key}: {estado.Value}");
            }
        }

        static void EliminarEstado()
        {
            Console.Write("Introduzca el nombre del estado que desea eliminar: ");
            string estado = Console.ReadLine();
            if (estados.ContainsKey(estado))
            {
                estados.Remove(estado);
                Console.WriteLine($"El estado {estado} ha sido eliminado.");
            }
            else
            {
                Console.WriteLine($"No se encontró el estado {estado}.");
            }
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
