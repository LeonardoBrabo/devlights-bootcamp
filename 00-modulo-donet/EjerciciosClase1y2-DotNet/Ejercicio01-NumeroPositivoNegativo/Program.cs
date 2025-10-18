namespace Ejercicio01_NumeroPositivoNegativo
{
    internal class Program
    {

        //Ejercicio 01 - Número positivo o negativo: Pedir un número y mostrar si es positivo, negativo o cero.

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para determinar si es positivo, negativo o cero:  ");
            int num;
            while (true)
            {
                bool conver = int.TryParse(Console.ReadLine(), out num);
                if (conver) 
                    break;
                else
                    Console.WriteLine("Intente de nuevo pero solo con numero: ");
                
            }
            if (num < 0)
                Console.WriteLine("El numero es Negativo");
            else if (num == 0)
                Console.WriteLine("El numero es Cero");
            else
                Console.WriteLine("El numero es Positivo");

        }
    }
}
