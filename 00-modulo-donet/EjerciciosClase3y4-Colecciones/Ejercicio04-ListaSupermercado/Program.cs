namespace Ejercicio04_ListaSupermercado
{
    internal class Program
    {
        /*4. Crear una variable para guardar los nombres de elementos para una “lista de supermercado”. Solicitar al usuario que ingrese el nombre de un elemento que va a comprar en el super y verificar que el elemento esté en la lista. Si no está, agregarlo e indicar que no estaba. Si está, quitarlo de la lista, y avisar que sí estaba. Al finalizar mostrar por pantalla los elementos que no compró y los que compró, pero no estaban en la lista. Si se quiere, mostrar también todos los elementos que el usuario compró. Para salir el usuario debe ingresar “fin”.*/
        static void Main(string[] args)
        {
            List<string> listaCompras = new List<string>() { "pan","leche","arroz","pizza","vino","cerveza"};
            List<string>listaImprevistos = new List<string>();
            List<string> listTodos = new List<string>();

            string elemento = "";

            while((!elemento.Equals("fin")) || string.IsNullOrWhiteSpace(elemento))
            {
                Console.WriteLine("Lista de Compras: ");

                Console.WriteLine(string.Join(", ", listaCompras));
                

                Console.WriteLine("Ingrese un producto o si quiere finalizar ingrese \"fin\" : ");

                elemento = Console.ReadLine().ToLower();


                if (listaCompras.Contains(elemento)) 
                {
                    Console.WriteLine($"El producto {elemento} se encontraba en la lista de compras");
                    listaCompras.Remove(elemento);
                    
                }
                else
                {
                    if (!elemento.Equals("fin"))
                    {
                        Console.WriteLine($"El producto {elemento} no estaba en la lista de compras");
                        Console.WriteLine($"Agregadp a lista de imprevistos");
                        listaImprevistos.Add(elemento);

                    }
                }

                if(!elemento.Equals("fin"))
                    listTodos.Add(elemento);              
                
            }

            Console.WriteLine("\n\nElementos que no se compraron de la lista: ");
            Console.WriteLine(string.Join(", ", listaCompras));

            Console.WriteLine("\nElementos que se compraron pero que no estaban en la listas:");
            Console.WriteLine(string.Join(", ",listaImprevistos));

            Console.WriteLine("\nTodo lo que se compro: ");
            Console.WriteLine(string.Join(", ",listTodos));

        }

        
    }
}
