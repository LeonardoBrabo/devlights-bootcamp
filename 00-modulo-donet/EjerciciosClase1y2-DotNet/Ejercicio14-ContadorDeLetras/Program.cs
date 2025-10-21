namespace Ejercicio14_ContadorDeLetras
{
    /*14. Contador de letras: Pedir una palabra y mostrar cuántas letras tiene*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("ingrese una palabra para determinar cuantas letras tiene");
            palabra = Console.ReadLine().Trim();

            Console.WriteLine($"La palabra contiene {palabra.Length} letras");





        }
    }
}
