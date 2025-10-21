namespace Ejercicio15_TablaMultiplicar
{
    /*15. Tabla de multiplicar: Pedir un número y mostrar su tabla de multiplicar del 1 al 10.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para obtener su tabla de multiplicar");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 11; i++) 
            {
                Console.WriteLine($"{num}*{i} = {num*i}");
            }
        }
    }
}
