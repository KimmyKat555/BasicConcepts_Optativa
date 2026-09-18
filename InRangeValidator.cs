namespace BasicConcepts_Optativa
{
    // Ejercicio 15: InRange Validator
    public class InRangeValidator : EjercicioBase
    {
        public InRangeValidator()
        {
            Nombre = "InRange Validator";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese un número entre el rango de 10 a 20: ");

            if (!double.TryParse(Console.ReadLine() ?? "", out double numero))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                return;
            }

            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("Resultado: Está en el rango.");
            }
            else
            {
                Console.WriteLine("Resultado: Fuera del rango.");
            }
        }
    }
}