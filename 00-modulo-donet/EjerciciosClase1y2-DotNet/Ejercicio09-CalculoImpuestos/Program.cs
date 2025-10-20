namespace Ejercicio09_CalculoImpuestos
{
    /*9. Cálculo de impuestos: Pedir un ingreso anual y calcular el impuesto: < 10,000: 0% 10,000–50,000: 10% 50,000: 20% Mostrar el monto de impuesto a pagar.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su ingreso anual, para calcular el impuesto:  ");
            decimal ingreso = decimal.Parse(Console.ReadLine());

            decimal totalImpuesto;
            if (ingreso > 50000.00m)  //impuesto del 20%
                totalImpuesto = ingreso * 0.2m;
            else if (ingreso >= 10000.00m) //impuesto del 10%
                totalImpuesto = ingreso * 0.1m;
            else
                totalImpuesto = 0; //si es menor a 10mil

            Console.WriteLine($"Ingreso anual: ${ingreso}\nImpuesto total: ${totalImpuesto}");

            
            

        }
    }
}
