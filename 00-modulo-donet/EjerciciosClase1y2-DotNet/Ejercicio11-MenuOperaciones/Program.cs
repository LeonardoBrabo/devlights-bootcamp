using System.Reflection.Metadata.Ecma335;

namespace Ejercicio11_MenuOperaciones
{
    /*11. Menú con switch: Crear un menú con opciones (1. Sumar, 2. Restar, 3. Multiplicar, 4. Dividir). Pedir dos números y ejecutar la operación elegida.*/
    internal class Program
    {

        static void Main(string[] args)
        {
            char continuar = 's';
            bool flag = false;
            byte opcionElegida = 0;
            double num1, num2;

            while ((continuar == 's') || (!flag) || (opcionElegida < 0 || opcionElegida > 4))
            {
                
                Console.WriteLine("Elija una opcion: ");
                Console.WriteLine("1-SUMAR\n2-RESTAR\n3-MULTIPLICAR\n4-DIVIDIR");
                flag = byte.TryParse(Console.ReadLine(), out opcionElegida);

                if ((opcionElegida < 0 || opcionElegida > 4) || !flag)
                    Console.WriteLine("Intente de nuevo pero solo ingresando los numero del 1 al 4");
                    
                else 
                {
                    switch (opcionElegida)
                    {
                        case 1:
                            Console.WriteLine("ELIGIO SUMA:");
                            IngresarNumeros(out num1, out num2);
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case 2:
                            Console.WriteLine("ELIGIO RESTA:");
                            IngresarNumeros(out num1, out num2);
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        case 3:
                            Console.WriteLine("ELIGIO MULTIPLICACION:");
                            IngresarNumeros(out num1, out num2);
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                            break;
                        case 4:
                            Console.WriteLine("ELIGIO SUMA:");
                            IngresarNumeros(out num1, out num2);
                            if (num2 == 0)
                                Console.WriteLine("No se puede dividir por cero");
                            else
                                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                            break;
                    }

                    Console.WriteLine("Desea continuar? s/n");
                    continuar = char.Parse(Console.ReadLine().ToLower());
                    

                }
               
               
            }

            
        }

        static void IngresarNumeros(out double n1, out double n2)
        {
                      
           
            Console.Write("Ingrese el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out n1))
            {
                Console.Write("Valor inválido. Ingrese un número válido: ");
            }

            Console.Write("Ingrese el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out n2))
            {
                Console.Write("Valor inválido. Ingrese un número válido: ");
            }         

        }
        
    }
}
