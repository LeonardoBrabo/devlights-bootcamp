using System.Xml;

namespace Ejercicio08_BuscarXEnMatriz
{
    /*8. Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad que el programador decida, pero no más de la mitad de los lugares disponibles en la matriz). El usuario deberá ingresar el lugar donde cree que hay una X, ingresando la fila y la columna por separado. Informar si acertó o no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya guardado. El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se
      terminaron los 3 intentos, o el jugador acertó todas las X) imprimir por pantalla la matriz con sus correspondientes X, mostrando un * donde no haya nada.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = new char[10, 10];
            byte intentosRestantes = 3;
            byte aciertos = 0;
            byte contadorIngresoValores;
            byte filaSel, columnaSel;
            byte cantidadDeX = 0;

            //necesito obtener indices de matrices aleatorios que esten entre 0 y 9 tanto para filas como columnas
            //tambien necesito calcular de forma aleatoria la cantidad de x que no sea mayor a la mitad de los posibles valores

            Random rand = new Random();


            cantidadDeX = (byte)(rand.Next(1, 11)); //obtengo de 1 a 10 X de forma aleatoria
            contadorIngresoValores = cantidadDeX;

            Console.WriteLine($"La cantidad de x escondidas es de: {cantidadDeX}");
            //este for seria para llenar la cantidad de X random
            for(int i = 0; i < cantidadDeX; i++)
            {

                int IndiceFilaX = (int)(rand.Next(0, 10)); 
                int IndiceColumnaX = (int)(rand.Next(0, 10));

                matrix[IndiceFilaX, IndiceColumnaX] = 'X';
                
            }


            //Me guio para saber donde estan
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!matrix[i, j].Equals('X'))
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                }

                Console.WriteLine();
            }




            while (contadorIngresoValores > 0 && intentosRestantes > 0)
            {
                Console.WriteLine($"Intentos Disponibles: {intentosRestantes}");
                Console.WriteLine($"Puede ingresar hasta {contadorIngresoValores} indices,");
                Console.WriteLine("Ingrese separado por coma la posición en la que cree que hay una x: ");

                
                string[] posicionIngresada = Console.ReadLine().Trim().Split(',');

                filaSel = byte.Parse(posicionIngresada[0]);
                columnaSel = byte.Parse(posicionIngresada[1]);

                if (matrix[filaSel,columnaSel] == 'X')
                {
                    Console.WriteLine($"Acertaste! en la posición ("+filaSel+","+columnaSel+") habia una X!");
                    aciertos++;
                    matrix[filaSel, columnaSel] = 'B'; //reemplaza la X por una B de bien!

                }
                else
                {
                    Console.WriteLine("Ups! no habia ningun X en esa posición :(");
                    intentosRestantes--;
                    matrix[filaSel, columnaSel] = 'M'; //le agrege para saber donde estaba la posición elegida sin X

                }

                contadorIngresoValores--;
            }


            //muestro las x donde estaban
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (!matrix[i, j].Equals('X') && !matrix[i, j].Equals('B') && !matrix[i, j].Equals('M'))
                    {
                        
                        Console.Write("* ");
                    }
                    else 
                    {
                        Console.Write(matrix[i, j] + " ");                   
                    }
                }

                Console.WriteLine();
            }
            
        }
    }
}
