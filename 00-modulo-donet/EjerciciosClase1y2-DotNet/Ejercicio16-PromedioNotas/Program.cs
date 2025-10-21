namespace Ejercicio16_PromedioNotas
{
    /*16. Promedio de notas: Pedir 5 notas, calcular el promedio y mostrar si el estudiante aprueba (>=6) o no.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] notas = new float[5];
            float suma = 0;
            Console.WriteLine("Ingrese 5 notas para determinar el estado el estudiante");
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"ingrese la nota numero {i+1}:");
                notas[i]= float.Parse(Console.ReadLine());
                suma += notas[i];

            }

            float promedio = suma / 5.00f;
            if(promedio >= 6)
                Console.WriteLine($"APROBADO CON: {promedio:F2}");
            else
                Console.WriteLine($"DESAPROBADO CON: {promedio:F2}");
            
            

        }
    }
}
