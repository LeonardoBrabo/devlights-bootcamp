namespace Ejercicio09_DiccionarioCalif
{
    using System.Globalization; //para capitalizar la primera letra de una palabra.

    /*9. Diccionario de calificaciones: Crear un diccionario donde la clave sea el nombre del alumno y el valor sea su nota. El programa debe permitir:
        a. Agregar alumnos y sus notas.
        b. Mostrar el promedio general del curso.
        c. Indicar el alumno con mejor nota y el de peor nota.
        d. Hint: usar Dictionary<string, double> y recorrer con foreach*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> calificaciones = new Dictionary<string, double>();

            string textoIngresado = "";
            double nota = 0.0;
            bool intentarConvertir = false;
            string PeorAlumno = "", MejorAlumno = "";
            double PeorNota = double.MaxValue, MejorNota = double.MinValue, promedio = 0.0;
            


            while (textoIngresado  != "Fin")
            {
                Console.WriteLine("Ingrese el nombre de un alumno o la palabra \"fin\" para finalizar: ");
                textoIngresado = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Console.ReadLine().ToLower()); //choclo para capitalizar la primera letra de la palabra

                if (textoIngresado != "Fin")
                {

                    do
                    {
                        Console.WriteLine($" Ingrese la calificacion de {textoIngresado}: ");
                        intentarConvertir = double.TryParse(Console.ReadLine(), out nota);

                        if (!intentarConvertir)
                        {
                            Console.WriteLine("Intentelo de nuevo ingrese solo un numero de calificacion valido con coma (,)");
                        }

                    } while (!intentarConvertir);

                    calificaciones.Add(textoIngresado, nota);

                } 
                else
                {

                    Console.WriteLine("Gracias por usar este programita! :)");
                }
            }

            
            foreach(var calificacion in calificaciones)
            {

                promedio += calificacion.Value; //obtengo la suma para el promedio.
                Console.WriteLine($"{calificacion.Key} -> Nota: {calificacion.Value}"); //muestro los alumnos y sus notas.

                //obtengo la mejor y pero nota con sus respectivos alumnos
                if(calificacion.Value > MejorNota)
                {
                    MejorNota = calificacion.Value;
                    MejorAlumno = calificacion.Key;
                }

                if(calificacion.Value < PeorNota)
                {
                    PeorNota = calificacion.Value;
                    PeorAlumno = calificacion.Key;
                }

                    
                
            }

            promedio /= calificaciones.Count(); //termino de obtener el promedio diviendo la suma por la cantidad de alumnos.

            Console.WriteLine($"El promedio general del curso: {promedio:F2}");
            Console.WriteLine($"El mejor alumno es: {MejorAlumno} con una nota de {MejorNota:F2}");
            Console.WriteLine($"El peor alumno es: {PeorAlumno} con una nota de {PeorNota:F2}");
        }
    }
}
