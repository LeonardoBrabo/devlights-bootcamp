namespace Ejercicio07_TablasMultiplicarM
{

    /*7. Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe guardar los números (de 0 a 9), estando el cero en la primera posición (fila 0, columna 0). El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3, etc. usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla*/
    internal class Program
    {

        static void Main(string[] args)
        {

            short[,] tabla = new short[10, 10];
            short valorFila1 = 0;
            short valorColumna1 = 0;
            //carga de columnas y del 1 al 9
            for(int i = 0; i < 10; i++)
            {                

                for(int j = 0; j <10; j++)
                {
                    //obtengo la fila 0 con los numero del 0 al 9
                    if(i == 0)
                    {
                        tabla[i, j] = valorFila1;
                        valorFila1++;
                    }

                    //obtengo la columna 0 con los numeros del 0 al 9
                    if(j == 0)
                    {
                        tabla[i, j] = valorColumna1;
                        valorColumna1++;
                    }
                    
                    //calculo los demas numeros de la tabla
                    if(i != 0 && j != 0)
                    {
                        tabla[i, j] = (short)(i * j);
                    }
                    
                   
                }
            }

            /*visualizo la matriz¨*/
            for(int i = 0; i < tabla.GetLength(0); i++)
            {
                for(int j = 0; j <tabla.GetLength(1); j++)
                {
                    Console.Write(tabla[i,j]+" ");
                }
                Console.WriteLine();
            }

        }
    }
}
