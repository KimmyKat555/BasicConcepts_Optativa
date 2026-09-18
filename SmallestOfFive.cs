namespace BasicConcepts_Optativa
{
    // Ejercicio 12: Smallest of Five
    public class SmallestOfFive : EjercicioBase
    {
        public SmallestOfFive()
        {
            Nombre = "Smallest of Five";
        }

        public override void Ejecutar()
        {
            const int cantidadNumeros = 5;
            double menor = double.MaxValue;

            for (int i = 1; i <= cantidadNumeros; i++)
            {
                Console.Write($"Ingrese el número {i}: ");
                if (!double.TryParse(Console.ReadLine() ?? "", out double numero))
                {
                    Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                    return;
                }

                if (numero < menor)
                {
                    menor = numero;
                }
            }

            Console.WriteLine($"Resultado: {menor}");
        }
    }
}