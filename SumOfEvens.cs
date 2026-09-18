namespace BasicConcepts_Optativa
{
    // Ejercicio 8: Sum of Evens
    public class SumOfEvens : EjercicioBase
    {
        public SumOfEvens()
        {
            Nombre = "Sum of Evens";
        }

        public override void Ejecutar()
        {
            int suma = 0;

            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"Resultado: {suma}");
        }
    }
}