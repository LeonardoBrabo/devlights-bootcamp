namespace Ejercicio03_NombreMasLargoCorto
{
    /*3. Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que tenga menos letras de todos.*/
    internal class Program
    {
        static void Main(string[] args)
        {
           List<string> nombres = new List<string>
           {
                "Lucía",
                "Martín",
                "Sofía",
                "Valentina",
                "Tomás",
                "Agustina",
                "Julián",
                "Camila",
                "Mateo",
                "Isabella",
                "Benjamín",
                "Florencia",
                "Lautaro",
                "Mía",
                "Santiago"
           };

            Console.WriteLine($"El nombre mas Largo de la lista es: {NombreMasLargo(nombres)}");
            Console.WriteLine($"El nombre mas corto de la lista es: {NombreMasCorto(nombres)}");

        }


        public static string NombreMasLargo (List<string> list)
        {
            int cantidadCaracteresLargo = 0;
            int indiceNombreMasLargo = 0;

            cantidadCaracteresLargo = list[0].Trim().Length;
            

            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Length >  cantidadCaracteresLargo )
                {
                    cantidadCaracteresLargo = list[i].Length;
                    indiceNombreMasLargo = i;
                }
            }

            return list[indiceNombreMasLargo];
        }

        public static string NombreMasCorto(List<string> list)
        {
            int cantidadCaracteresCorto = 0;
            int indiceNombreMasCorto = 9999;

            cantidadCaracteresCorto = list[0].Trim().Length;


            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Length < cantidadCaracteresCorto )
                {
                    cantidadCaracteresCorto = list[i].Length;
                    indiceNombreMasCorto = i;
                }
            }

            return list[indiceNombreMasCorto];
        }


    }
}
