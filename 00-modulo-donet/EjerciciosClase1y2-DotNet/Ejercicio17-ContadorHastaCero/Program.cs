namespace Ejercicio17_ContadorHastaCero
{
    /*17. Contador hasta que sea cero: Pedir números enteros hasta que el usuario ingrese 0. Mostrar la cantidad de números introducidos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listaNumeros = new List<int>();
            int numero = 1;
            while (numero != 0) 
            {
                Console.WriteLine("Ingrese un numero entero, para finalizar ingrese cero (0): ");
                numero = int.Parse(Console.ReadLine());
                listaNumeros.Add(numero);
                Console.Clear();
                
            
            }

            Console.WriteLine($"Cantidad de numeros ingresados {listaNumeros.Count}");
            Console.WriteLine("Numeros ingresados: "+string.Join(", ", listaNumeros));
        }
    }
}
