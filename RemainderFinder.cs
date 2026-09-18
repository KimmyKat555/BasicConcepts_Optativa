namespace BasicConcepts_Optativa
{
    // Ejercicio 7: Remainder Finder
    public class RemainderFinder : EjercicioBase
    {
        public RemainderFinder()
        {
            Nombre = "Remainder Finder";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese el primer número (dividendo): ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int primerNumero))
            {
                Console.WriteLine("Entrada no válida para el primer número.");
                return;
            }

            Console.Write("Ingrese el segundo número (divisor): ");
            if (!int.TryParse(Console.ReadLine() ?? "", out int segundoNumero))
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
                return;
            }

            if (segundoNumero == 0)
            {
                Console.WriteLine("Error: No es posible dividir entre cero.");
                return;
            }

            int residuo = primerNumero % segundoNumero;
            Console.WriteLine($"Resultado: {residuo}");
        }
    }
}