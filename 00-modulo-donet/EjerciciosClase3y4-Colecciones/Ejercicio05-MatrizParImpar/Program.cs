namespace Ejercicio05_MatrizParImpar
{
    /*5. Crear una matriz de 5 x 5. Almacenar una ‘I’ en lugares impares y una ‘P’ en lugares pares. Imprimir la matriz por pantalla*/
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] arr = new char[5, 5]; 
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        arr[i, j] = 'P';
                    }
                    else
                        arr[i, j] = 'I';
                }
            }

            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i,j]+ " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
