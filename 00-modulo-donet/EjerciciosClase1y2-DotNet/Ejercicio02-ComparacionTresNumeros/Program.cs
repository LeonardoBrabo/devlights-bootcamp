using System.Runtime.CompilerServices;

namespace Ejercicio02_ComparacionTresNumeros
{
    internal class Program
    {
        //Comparación de tres números: Pedir tres números distintos y mostrar cuál es el mayor y cuál el menor.
        
        //versión basica.

        static void Main(string[] args)
        {
            int num1, num2, num3,mayor = 0 ,menor = 0;


            Console.WriteLine("Ingrese tres numeros: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse (Console.ReadLine());
            num3 = int.Parse (Console.ReadLine());

            Console.WriteLine($"Los numeros ingresado son: {num1}, {num2}, {num3}");

            //determinación del mayor
            if (num1 > num2
              && num1 > num3)
                mayor = num1;
            else if (num2 > num1
                && num2 > num3)
                mayor = num2;
            else if (num3 > num1
                && num3 > num2)
                mayor = num3;
           
            //determinación del menor
            if (num1 < num2
               && num1 < num3)
                menor = num1;
            else if (num2 < num1
                && num2 < num3)
                menor = num2;
            else if (num3 < num2)
                menor = num3;

            Console.WriteLine($"El numero MAYOR es: {mayor}\nEl numero MENOR es: {menor}");  

        }
    }
}
