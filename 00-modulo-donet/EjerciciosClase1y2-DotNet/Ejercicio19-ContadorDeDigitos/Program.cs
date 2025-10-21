namespace Ejercicio19_ContadorDeDigitos
{
    /*19. Contador de dígitos: Pedir un número entero y decir cuántos dígitos tiene.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esNumero = true;
            Console.WriteLine("Ingrese un numero para determinar cuantos digitos posee");
            string numero = Console.ReadLine();


            foreach( char  c in numero)
            {
                if (!char.IsDigit(c))
                {
                    esNumero = false;
                    break;
                }
            }

            if (esNumero)
                Console.WriteLine("Cantidad de digitos: " + numero.Length);
            else
                Console.WriteLine("La entrada contiene caracteres no numericos.");

        }
    }
}
