namespace BasicConcepts_Optativa
{
    // Ejercicio 14: Factorial Finder
    public class FactorialFinder : EjercicioBase
    {
        public FactorialFinder()
        {
            Nombre = "Factorial Finder";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese un número entero no negativo: ");

            if (!int.TryParse(Console.ReadLine() ?? "", out int numero) || numero < 0)
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero mayor o igual a 0.");
                return;
            }

            long factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Resultado: {factorial}");
        }
    }
}