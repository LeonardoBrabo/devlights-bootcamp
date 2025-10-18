namespace Ejercicio03_Multiplos
{
    internal class Program
    {
        /*Múltiplos de un número: Pedir dos números e indicar si el primero es múltiplo del segundo. */

        static void Main(string[] args)
        {

            int num1, num2;
            char conti = 's';

            while (conti == 's')
            {
                Console.WriteLine("Ingrese dos numero, para saber si el primero es multiplo del segundo.");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                if (num1 % num2 == 0)
                    Console.WriteLine($"{num1} es multiplo de {num2}");
                else
                    Console.WriteLine($"{num1} no es multplo de {num2}");

                Console.WriteLine("Probar de nuevo? s/n?");
               conti = char.Parse(Console.ReadLine().ToLower());                               
                
            }
            
        }
    }
}
