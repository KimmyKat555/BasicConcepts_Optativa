namespace BasicConcepts_Optativa
{
    // Ejercicio 1: Positive Power
    public class PositivePower : EjercicioBase
    {
        public PositivePower()
        {
            Nombre = "Positive power";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese un numero: ");
            
            if (!double.TryParse(Console.ReadLine() ?? "", out double numero))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un numero.");
                return;
            }

            if (numero > 0)
            {
                Console.WriteLine($"Resultado: {numero * numero}");
            }
            else if (numero < 0)
            {
                Console.WriteLine("Resultado: Número negativo.");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
    }
}