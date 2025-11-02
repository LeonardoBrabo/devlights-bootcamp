using System.Collections.Immutable;

namespace Ejercicio06_TemperaturasCabina
{
    /*6. Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana. La estructura es para registrar la temperatura diaria de una cabina de pago, estos oscilan entre los 7 y 38 grados. Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se ubica en el miércoles (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, no es necesario pedir los valores al usuario para cada posición). Se nos pide hacer lo siguiente:
            a. Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
            b. Promedio de temperatura de la semana.
            c. Temperatura más alta del mes y su día.*/
    internal class Program
    {
        enum diaDeLaSemana { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo };

        static void Main(string[] args)
        {
            //despues de la arr[4,2] ya es otro mes, contemplar eso, este es el dia miercoles 31 de mayo.


            Random rand = new Random();



            byte[,] mayoTemp = new byte[5, 7];
            
            int indiceMayor = -1;
            int indiceMenor = 7;
            byte valorMayor = 6;
            byte valorMenor = 40;
            

            

            /*cargo la matriz 5x7*/
            for(int i = 0; i < mayoTemp.GetLength(0); i++)
            {
                for(int j = 0; j < mayoTemp.GetLength(1); j++)
                {
                    mayoTemp[i, j] = (byte)rand.Next(7, 39);
                }
            }

            Console.WriteLine("L  M  X  J  V  S  D");
            /*muestro la matriz*/
            for (int i = 0; i < mayoTemp.GetLength(0); i++)
            {
                for (int j = 0; j < mayoTemp.GetLength(1); j++)
                {

                    Console.Write(mayoTemp[i, j] + " ");
                }

                Console.WriteLine();
            }

             /*Calculo el dia mayor y menor de cada semana*/
             for (int i = 0; i < mayoTemp.GetLength(0); i++)
             {
                 indiceMayor = -1; //reinicializo los contadores por semana
                 indiceMenor = 7;
                 valorMayor = 6;
                 valorMenor = 40;


                for (int j = 0; j < mayoTemp.GetLength(1); j++)
                {
                                       
                    
                    if (mayoTemp[i, j] >= valorMayor) //obtengo el mayor valor y su indice
                    {
                        valorMayor = mayoTemp[i, j];
                        indiceMayor = j;
                    }

                    if (mayoTemp[i, j] < valorMenor) //obtengo el menor valor y su indice
                    {
                        valorMenor = mayoTemp[i, j];
                        indiceMenor = j;
                    }
                   
                                  
                }                
               
                Console.WriteLine($"\nSemana {i+1} La temperatura mas alta fue {valorMayor} que fue el dia {(diaDeLaSemana)indiceMayor} y la temperatura mas baja fue {valorMenor} que fue el dia {(diaDeLaSemana)indiceMenor} ");
                
             }
        }
    }
}
