namespace Ejercicio12_ContadorDePares
{
    /*12. Contador de pares: Pedir un número N y mostrar cuántos números pares hay entre 1 y N.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ushort> pares = new List<ushort>();
            Console.WriteLine("Ingrese un numero para determinar cuantos numeros pares le anteceden:");
            ushort n = ushort.Parse(Console.ReadLine()); 
            ushort cont = 0;
            for (int i = 1; i < n+1; i++)
            {
                if (i % 2 == 0)
                {
                    cont++;
                    pares.Add((ushort)i);
                                
                }
            }

            Console.WriteLine($"Entre el 1 al {n} existen {cont} numero pares.");
            Console.WriteLine(string.Join(", ",pares));
            

        }
    }
}
