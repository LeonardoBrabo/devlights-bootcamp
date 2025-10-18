namespace Ejercicio04_DescuentoTienda
{
    /*Descuento en tienda: Pedir el precio de un producto y aplicar un descuento del 10% si el precio es mayor a $1000*/
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precio,descuento = 0.00m;
           

            Console.WriteLine("Ingrese el precio de un producto: ");
            precio = decimal.Parse(Console.ReadLine());

            if (precio > 1000.00m)
            {
                Console.WriteLine("El precio es mayor a $1000 -> tiene descuento del 10%");
                descuento = precio * 0.10m;
            }
       

            Console.WriteLine($"Precio Real: ${precio}" +
                $"\nDecuento: ${descuento}" +
                $"\nPrecioFinal: ${precio - descuento}");
        }
    }
}
