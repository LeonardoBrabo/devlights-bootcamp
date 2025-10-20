using System.Globalization;

namespace Ejercicio08_ParOImpar
{
    //8. Operador ternario: Pedir un número y mostrar "Par" o "Impar" usando el operador ternario.
    internal class Program
    {
        static void Main(string[] args)
        {
            char continuar = 's';
            bool flag = false;
            int numero = 0;

            while (continuar == 's' || !flag)
            {
                
                Console.WriteLine("Ingrese un número para determinar si es par o impar");

                flag = int.TryParse(Console.ReadLine(), out numero);

                if (!flag)
                {
                    Console.WriteLine("Vuelva a intentarlo pero solo con numeros");
                }
                else 
                {
                    Console.WriteLine(
                        (numero % 2 == 0)
                        ? $"El numero {numero} es PAR"
                        : $"El numero {numero} es IMPAR");

                    Console.WriteLine("Probar de nuevo? s/n");
                    continuar = char.Parse(Console.ReadLine().ToLower());

                }                             
                
            }
        }
    }
}
