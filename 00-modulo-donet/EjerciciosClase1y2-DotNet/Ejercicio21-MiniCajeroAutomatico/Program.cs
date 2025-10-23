namespace Ejercicio21_MiniCajeroAutomatico
{
    /*21. Mini cajero automático
        Simular un cajero con un saldo inicial. Mostrar un menú con opciones:
            ● 1) Consultar saldo
            ● 2) Depositar
            ● 3) Retirar
            ● 4) Salir
        Validar que no se retire más de lo que hay y que los montos sean positivos.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            byte opcion = 4;
            bool flag = false;
            decimal saldo = 250000.50m;         
            decimal deposito = 0;
            decimal retirar = 0;
            bool permitido;


            while ((opcion != 4) || (!flag) || (opcion < 1 || opcion > 4))
            {
                Console.WriteLine("CAJERO AUTOMATICO");
                Console.WriteLine("1) Consultar saldo\n2) Depositar\n3) Retirar\n4) Salir");

                flag = byte.TryParse(Console.ReadLine(), out opcion);
                if ((!flag) || (opcion < 1 || opcion > 4))
                {
                    Console.WriteLine("Ingrese solamente numeros de 1 al 4 como opciones. Intente de nuevo");
                }
                else
                {
                    switch (opcion)
                    {

                        case 1:
                            Console.WriteLine($"Su saldo es: ${saldo}");
                            break;
                        case 2:
                            permitido = false;
                            while (!permitido) 
                            {
                                Console.WriteLine($"Ingrese el valor que quiere depositar: ");
                                permitido = decimal.TryParse(Console.ReadLine(), out deposito);
                                if (deposito < 0 || !permitido)
                                {
                                    Console.WriteLine("Solo ingrese valores numericos positivos");
                                    permitido = false;

                                }
                                else
                                    saldo += deposito;
                                
                            }
                            break;
                        case 3:
                            permitido = false;
                            while (!permitido)
                            {
                                Console.WriteLine($"Ingrese el valor que quiere retirar: ");
                                permitido = decimal.TryParse(Console.ReadLine(), out retirar);
                                if (retirar < 0 || !permitido)
                                {
                                    Console.WriteLine("Solo ingrese valores numericos positivos");
                                    permitido = false;

                                }
                                else if(retirar > saldo)
                                {
                                    permitido = false;
                                    Console.WriteLine($"El monto a retirar ${retirar}, es mayor al saldo disponible ${saldo}, vuelva a ingresar un valor valido.");
                                }
                                else
                                {
                                    saldo -= retirar;
                                    Console.WriteLine($"se retiro: ${retirar}, saldo actual: ${saldo}");

                                }

                            }
                            break;
                        case 4:
                            Console.WriteLine("Gracias...Vuelva pronto!");
                            break;

                    }

                }
                  
            }
        }
    }
}
