namespace BasicConcepts_Optativa
{
    // Ejercicio 6: Tax Calculator
    public class TaxCalculator : EjercicioBase
    {
        public TaxCalculator()
        {
            Nombre = "Tax Calculator";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese su salario anual: ");

            if (!double.TryParse(Console.ReadLine() ?? "", out double salario))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                return;
            }

            if (salario < 0)
            {
                Console.WriteLine("El salario no puede ser negativo.");
                return;
            }

            const double limiteBase = 12000;
            const double porcentajeImpuesto = 0.15;

            if (salario > limiteBase)
            {
                double excedente = salario - limiteBase;
                double impuesto = excedente * porcentajeImpuesto;
                Console.WriteLine($"Resultado: {impuesto}");
            }
            else
            {
                Console.WriteLine("Resultado: No debe impuestos.");
            }
        }
    }
}