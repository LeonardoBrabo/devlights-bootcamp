namespace Ejercicio02_MayoresDeEdad
{
    /*2. Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            List<byte> edades = new List<byte> { 12, 17, 18, 20, 25, 30, 15, 16, 22, 19, 14, 13, 28, 35, 40, 10, 21, 26, 8, 33 };
            byte conMenor = 0, conMayor = 0;

            foreach(byte edad in edades)
            {
                if(edad < 18)
                    conMenor++;
                else
                    conMayor++;
            }

            Console.WriteLine($"Cantidad de Menores de edad: {conMenor}\nCantidad de Mayores de edad: {conMayor}");
        }
    }
}
