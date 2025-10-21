namespace Ejercicio13_SumaImpares
{
    /*13. Suma de números impares: Calcular la suma de los números impares del 1 al 100.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            ushort suma = 0;
            for (byte i = 1; i < 101; i++)
            {
                if(i % 2 != 0)
                    suma += i;
            }
            Console.WriteLine($"La suma de los valores impares del 1 al 100 es: {suma}");
        }
    }
}
