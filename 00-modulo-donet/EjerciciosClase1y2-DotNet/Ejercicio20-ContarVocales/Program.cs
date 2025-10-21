namespace Ejercicio20_ContarVocales
{
    /*20. Contar vocales: Pedir una palabra y contar cuántas vocales tiene.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            ushort contVocal = 0;
            Console.WriteLine("Ingrese una palabra para saber cuantas vocales possee: ");
            palabra = Console.ReadLine().ToLower().Trim();
            for (int i = 0; i < palabra.Length; i++)
            {
                switch (palabra[i])
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        contVocal++;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine("Cantidad de vocales: "+contVocal);
        }
    }
}
