namespace BasicConcepts_Optativa
{
    // Ejercicio 11: Average of Four
    public class AverageOfFour : EjercicioBase
    {
        public AverageOfFour()
        {
            Nombre = "Average of Four";
        }

        public override void Ejecutar()
        {
            double suma = 0;
            const int cantidadNumeros = 4;

            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                if (!double.TryParse(Console.ReadLine() ?? "", out double numero))
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                    return;
                }
                suma += numero;
            }

            double promedio = suma / cantidadNumeros;
            Console.WriteLine($"Resultado: {promedio}");
        }
    }
}