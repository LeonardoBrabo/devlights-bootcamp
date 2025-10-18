namespace Ejercicio06_ClasificacionPorEdad
{
    /*Clasificación por edad: Pedir la edad y mostrar si la persona es niño, adolescente,
      adulto o adulto mayor (usa if-else if-else).*/
    internal class Program
    {
        static void Main(string[] args)
        {
            char otra = 's';
            while (otra == 's') 
            {
                System.Console.Clear();
                byte edad;
                Console.WriteLine("Ingrese su edad para determinar su clasificación: ");
                edad = byte.Parse(Console.ReadLine());

                if (edad < 13)
                    Console.WriteLine("NIÑO");
                else if (edad < 18)
                    Console.WriteLine("ADOLESCENTE");
                else if (edad >= 18 && edad < 65)
                    Console.WriteLine("ADULTO");
                else
                    Console.WriteLine("ADULTO MAYOR");

                Console.WriteLine("Quire probar de nuevo? s/n");
                otra = char.Parse(Console.ReadLine().ToLower());

            }
            
        }
    }
}
