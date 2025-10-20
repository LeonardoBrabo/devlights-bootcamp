namespace Ejercicio10_DiaDeLaSemana
{
    /*10. Día de la semana con switch: Pedir un número del 1 al 7 y mostrar el día de la semana correspondiente.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            byte dia = 0;

            while (!flag)
            {
                Console.WriteLine("Dias de la semana - Ingrese un numero del 1 al 7 :");
                flag = byte.TryParse(Console.ReadLine(), out dia);

                if (!flag)
                    Console.WriteLine("Intente de nuevo pero solo con numeros:");
            }
            
            switch (dia)
            {
                case 1:
                    Console.WriteLine("LUNES");
                    break;
                case 2:
                    Console.WriteLine("MARTES");
                    break;
                case 3:
                    Console.WriteLine("MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("JUEVES");
                    break;
                case 5:
                    Console.WriteLine("VIERNES");
                    break;
                case 6:
                    Console.WriteLine("SABADO");
                    break;
                case 7:
                    Console.WriteLine("DOMINGO");
                    break;
                default:
                    Console.WriteLine("Fuera de rango");
                    break;

            }
            
            
        }
                  
    }
}
