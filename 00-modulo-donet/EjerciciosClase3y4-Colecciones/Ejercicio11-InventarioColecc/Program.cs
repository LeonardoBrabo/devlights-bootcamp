using System.Xml;

namespace Ejercicio11_InventarioColecc
{
    /*11. Inventario con múltiples colecciones: Diseñar un sistema de inventario básico usando distintas colecciones:
        a. Un List<string> con los productos disponibles.
        b. Un Dictionary<string, int> para registrar el stock de cada producto.
        c. Un Stack<string> para llevar el historial de acciones realizadas (agregar, quitar, vender).
        d. El programa debe permitir:
        i. Agregar un producto y su cantidad.
        ii. Vender un producto (restando stock).
        iii. Mostrar el inventario actual.
        iv. Mostrar las últimas 3 acciones registradas.
        e. Hint: combina listas, diccionarios y pilas para manipular distintos tipos de información.*/
    internal class Program
    {
       

        public static void CargarProducto(out string nombreProd, out  int cantidadProd, List<string> listaProdDispo)
        {

            Console.WriteLine("CARGA DE  PRODUCTO:");

            while (true)
            {
                Console.WriteLine("Ingrese nombre del producto: ");
                nombreProd = Console.ReadLine().Trim().ToLower();

                if (listaProdDispo.Contains(nombreProd)) 
                {
                    Console.WriteLine($"el producto {nombreProd} ya existe, ingrese otro distinto");
                   
                }
                else
                {
                    listaProdDispo.Add(nombreProd);
                    break;
                }

            }


            Console.WriteLine("Ingrese la cantidad del producto: ");
            while (true)
            {
                bool permitido = int.TryParse(Console.ReadLine(), out cantidadProd);

                if (!permitido || cantidadProd < 0)
                {
                    Console.WriteLine("Ingrese un numero valido, intente nuevamente");
                }
                else 
                {
                    break;
                }
            }

        }


        static void Main(string[] args)
        {
            List<string> productosDisponibles = new List<string>();

            Dictionary<string, int> diStock = new Dictionary<string, int>();

            Stack<string> pilaAcciones = new Stack<string>();

            
            byte opcion = 0;
            bool noValido = false;
            while(opcion != 5)
            {
                Console.Clear();
                Console.WriteLine("1-Agregar un producto y cantidad.");
                Console.WriteLine("2-Vender un producto");
                Console.WriteLine("3-Ver inventario actual");
                Console.WriteLine("4-Ver ultimas 3 acciones registradas");
                Console.WriteLine("5-Salir");

                Console.Write("Ingrese el numero de una de las opciones: ");
                noValido = byte.TryParse(Console.ReadLine(), out opcion);


                string productoNom;
                int productoCant;

                switch (opcion)
                {
                    case 1:

                        CargarProducto(out productoNom, out productoCant, productosDisponibles);
                        diStock.Add(productoNom, productoCant);
                        Console.WriteLine("producto agregado correctamente al stock");
                        pilaAcciones.Push("@-carga-de-producto->"+productoNom);
                        break;

                    case 2:

                        if (productosDisponibles.Count > 0)
                        {

                            byte numeroProd = 0;
                            Console.WriteLine("Productos disponibles: ");
                            Console.WriteLine("--------------------------");
                            foreach (string producto in productosDisponibles)
                            {
                                Console.WriteLine($"{numeroProd}-" + producto);
                                numeroProd++;
                            }
                            Console.WriteLine("--------------------------");
                            Console.WriteLine();


                            while (true)
                            {

                                Console.WriteLine("Ingrese el numero de producto a vender: ");
                                //numeroProd = byte.Parse(Console.ReadLine());
                                if (!byte.TryParse(Console.ReadLine(), out numeroProd) || numeroProd < 0 || numeroProd > productosDisponibles.Count() - 1)
                                {
                                    Console.WriteLine("Por favor solo ingrese numero validos y solo los que aparecen en el listado");
                                }
                                else
                                {
                                    break;
                                }


                            }

                            bool bandera = false;
                            foreach (var productoEnStock in diStock)
                            {
                                if (productoEnStock.Key == productosDisponibles[numeroProd])
                                {
                                    bandera = true;
                                    Console.WriteLine($"Cuanto desea vender del producto {productoEnStock.Key}?");
                                    Console.WriteLine($"Se encuentra disponible {productoEnStock.Value} unidades del producto.");

                                    while (true)
                                    {
                                        Console.WriteLine($"Ingrese cuantas unidades va a vender: ");
                                        if (!int.TryParse(Console.ReadLine(), out productoCant) || productoCant < 0)
                                        {
                                            Console.WriteLine("Ingrese una cantidad valida para vender del producto, recuerde no puede ser menor a cero");
                                        }
                                        else
                                        {
                                            if (productoEnStock.Value >= productoCant)
                                            {
                                                diStock[productosDisponibles[numeroProd]] -= productoCant;
                                                Console.WriteLine("Producto vendido exitosamente!");
                                                pilaAcciones.Push("@-venta-de-producto->" + productoEnStock.Key);

                                                Console.WriteLine("Presione enter para volver al menu:");
                                                Console.ReadKey();

                                                break;

                                            }
                                            else
                                            {
                                                Console.WriteLine("La cantidad a vender no puede mayor al stock disponible");

                                            }



                                        }
                                        
                                    }

                                }

                            }

                            if (!bandera) Console.WriteLine("El producto no se encuentra.");




                        }
                        else
                        {
                            Console.WriteLine("Ningun Producto cargado aun");
                            Console.WriteLine("Presione enter para volver al menu:");
                            Console.ReadKey();
                        }
                           

                        
                            break;
                    case 3:

                        byte numProd = 0;
                        Console.WriteLine("LISTA DE PRODUCTOS DISPONIBLES Y STOCK");
                        Console.WriteLine("-------------------------------------");
                        foreach (KeyValuePair<string,int> producto in diStock)
                        {   
                            numProd++;
                            Console.WriteLine($"{numProd}-{producto.Key} ---> Stock {producto.Value}");
                        }
                        Console.WriteLine("-------------------------------------");
                        Console.WriteLine("Presione enter para volver al menu:");
                        Console.ReadKey();
                        pilaAcciones.Push("@-visualizo-listado-stock-");
                        break;
                    case 4:
                        Console.WriteLine("LISTADO ULTIMAS 3 ACCIONES REALIZADAS");
                       
                        int cont = 0;
                        foreach(string accion in pilaAcciones)
                        {   
                            if(cont < 3)
                            {
                                Console.WriteLine(accion);
                                cont++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Presione enter para volver al menu:");
                        Console.ReadKey();

                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar el programa :) , Hasta luego!");
                        Console.ReadKey();
                        
                        break;
                    default:
                        Console.WriteLine("Opcion no disponible solo ingrese del 1 al 5");
                        Console.WriteLine("Presione enter para volver al menu:");
                        Console.ReadKey();
                        break;
                }

            }



        }
    }
}
