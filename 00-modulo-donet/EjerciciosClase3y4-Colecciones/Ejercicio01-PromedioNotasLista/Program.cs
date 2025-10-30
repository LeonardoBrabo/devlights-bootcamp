namespace Ejercicio01_PromedioNotasLista
{
    /*1. Dado que se tiene almacenado en una lista, los resultados de los últimos 10 exámenes de un alumno, calcular su promedio y mostrar por pantalla las 10 notas de los exámenes y el promedio resultante.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            float[] notas = { 8.5f, 7.3f, 9.0f, 6.8f, 10.0f, 5.5f, 7.9f, 8.2f, 6.0f, 9.4f };
            float promedio, suma = 0.0F;
            foreach (float nota in notas) 
            {
                Console.WriteLine($"Nota: {nota}");
                suma += nota;

            }

            promedio = suma / (float)notas.Length;

            Console.WriteLine($"El promedio de las notas es: {promedio}");
        }

    }
}
