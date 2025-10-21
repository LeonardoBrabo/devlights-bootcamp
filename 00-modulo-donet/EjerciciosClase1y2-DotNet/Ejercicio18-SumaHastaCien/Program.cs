namespace Ejercicio18_SumaHastaCien
{
    /*18. Suma acumulada con condición: Pedir números y sumar hasta que la suma supere 100. Mostrar cuántos números se ingresaron.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0, numero;
            List<int> lista = new List<int>();
            while (suma <= 100) 
            {
                Console.WriteLine($"La suma va en: {suma}  falta {(100-suma)+1} para superar a 100");
                Console.WriteLine("Ingrese un numeros, cuando la suma de los numero supere a 100 termina: ");
                numero = int.Parse(Console.ReadLine());
                lista.Add(numero);
                suma += numero;
                
            }
            Console.WriteLine($"Cantidad de numeros ingresados {lista.Count}");
        
        }
    }
}
