using System.Reflection.Metadata.Ecma335;

namespace Ejercicio11_MenuOperaciones
{
    /*11. Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir). Pedir dos números y ejecutar la operación elegida.*/
    internal class Program
    {

        static void Main(string[] args)
        {
            char continuar = 's';
            

            while(continuar == 's')
            {
                switch (Menu())
                {
                    case 1:
                     
                }
            }
        }

        static byte Menu()
        {
            bool flag = false;
            byte opcionElegida = 0;

            while (!flag)
            {
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1-SUMAR\n2-RESTAR\n3-MULTIPLICAR\n4-DIVIDIR");
                flag = byte.TryParse(Console.ReadLine(), out opcionElegida);

            }

            return opcionElegida;

            
        }
    }
}
