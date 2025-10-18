namespace Ejercicio07_NumeroEnRango
{
    /*Número dentro de rango: Pedir un número y verificar si está dentro del rango 1–100
    (inclusive). */
    internal class Program
    {
        static void Main(string[] args)
        {
            char salir = 's';

            while (salir == 's') 
            {

                try
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese un numero para saber si esta en el rango");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero > 0 && numero < 101)
                        Console.WriteLine("El numero está dentro del rango 1-100");
                    else
                        Console.WriteLine("El numero está fuera de rango");


                }
                catch (OverflowException)
                {
                    Console.WriteLine("El numero está MUY fuera de rango.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Solo ingrese numero, intente de nuevo");
                }
                finally
                {
                    Console.WriteLine("Intentar de nuevo? s/n");
                    salir = char.Parse(Console.ReadLine().ToLower());

                }


            }            
        }
    }
}
