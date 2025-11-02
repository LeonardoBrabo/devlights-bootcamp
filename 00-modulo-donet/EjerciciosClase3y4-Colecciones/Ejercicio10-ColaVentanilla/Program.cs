using System.Threading.Channels;

namespace Ejercicio10_ColaVentanilla
{
    /*10. Simulador de atención en ventanilla: Usar una cola (Queue) para simular la atención de clientes en una ventanilla bancaria.
        a. Encolar nombres de clientes.
        b. Atender (desencolar) uno por uno hasta que no queden.
        c. Mostrar en pantalla quién está siendo atendido y cuántos quedan en la fila.
        d. Hint: usar Enqueue(), Dequeue() y Count.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clientes = new Queue<string>();
            Random rand = new Random(); //para simular tiempos aleatorios de atención.
            int cantClientes = 0;

            string texto = "";
            while (texto != "fin")
            {
                Console.WriteLine("Ingrese Nombre de clientes o finalice con escribiendo fin: ");
                texto = Console.ReadLine().Trim().ToLower();

                if (!texto.Equals("fin"))
                {
                    clientes.Enqueue(texto);


                    Console.WriteLine(string.Join(",", clientes));
                    Console.WriteLine();
                }
                                
            }

            Console.Clear();
            Console.WriteLine("Atendiendo Clientes:");

            
            
            while(clientes.Count() > 0)
            {

                Console.Clear();
                Console.WriteLine(string.Join(",", clientes));
                Console.WriteLine($"Quedan {clientes.Count()} clientes por ser atendidos");
                Console.WriteLine($"Atendiendo al cliente {clientes.Peek()}, aguarde...");

                Thread.Sleep(rand.Next(1000, 11000)); //duermo el hilo entre 1 segundo y 10 seg aleatoriamente.

                Console.WriteLine($"Atencion finaliada con el cliente {clientes.Peek()}");
                clientes.Dequeue();

                Console.WriteLine("Presione Enter para continuar,con el siguiente cliente");
                Console.ReadKey();

                if (clientes.Count == 0)
                {
                    Console.WriteLine("Todos los clientes fueron atendidos");
                    break;
                }


            }

            
            
        }
    }
}
