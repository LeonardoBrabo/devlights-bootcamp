using Microsoft.VisualBasic;

namespace Ejercicio05_ConversionDecimalEntero
{
    /*Conversión de tipo: Pedir un número decimal y convertirlo a entero(usando
    conversión explícita). Mostrar ambos valores y comentar la diferencia.*/

    internal class Program
    {
        static void Main(string[] args)
        {
            decimal valor = 0.00m;
            bool flag = false;

            while (!flag)
            {
                Console.WriteLine("Ingrese un valor decimal (con coma) para convertirlo a entero: ");

                flag = decimal.TryParse(Console.ReadLine(), out valor);

                if(!flag)
                    Console.WriteLine("solo ingrese numeros.");
                
            
            }

            int valorEntero = (int)valor;
            Console.WriteLine($" Valor decimal: {valor}\nValor entero: {valorEntero}");


        }
    }
}
