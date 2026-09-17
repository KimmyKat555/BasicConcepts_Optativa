namespace BasicConcepts_Optativa
{ // Ejercicio 2: Double or Triple
    public class DoubleOrTriple : EjercicioBase
    {
        public DoubleOrTriple()
        {
            Nombre = "Double or Triple";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese el primer numero: ");
            if (!double.TryParse(Console.ReadLine() ?? "", out double primerNumero))
            {
                Console.WriteLine("Entrada no válida para el primer número.");
                return;
            }

            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine() ?? "", out double segundoNumero))
            {
                Console.WriteLine("Entrada no válida para el segundo número.");
                return;
            }

            if (primerNumero > segundoNumero)
            {
                Console.WriteLine($"Resultado: {primerNumero * 2}");
            }
            else
            {
                Console.WriteLine($"Resultado: {segundoNumero * 3}");
            }
        }
    }
}
