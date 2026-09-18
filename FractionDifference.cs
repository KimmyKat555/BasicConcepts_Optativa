namespace BasicConcepts_Optativa
{
    // Ejercicio 9: Fraction Difference
    public class FractionDifference : EjercicioBase
    {
        public FractionDifference()
        {
            Nombre = "Fraction Difference";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese la primera fracción (ej. 1/2): ");
            string entrada1 = Console.ReadLine() ?? "";

            Console.Write("Ingrese la segunda fracción (ej. 1/3): ");
            string entrada2 = Console.ReadLine() ?? "";

            if (!ProcesarFraccion(entrada1, out int num1, out int den1) ||
                !ProcesarFraccion(entrada2, out int num2, out int den2))
            {
                Console.WriteLine("Entrada no válida. Use el formato 'a/b' con números enteros.");
                return;
            }

            if (den1 == 0 || den2 == 0)
            {
                Console.WriteLine("El denominador no puede ser cero.");
                return;
            }

            // Resta de fracciones: (a/b) - (c/d) = (a*d - c*b) / (b*d)
            int numResta = num1 * den2 - num2 * den1;
            int denResta = den1 * den2;

            if (numResta == 0)
            {
                Console.WriteLine("Resultado: 0");
            }
            else
            {
                // Simplificación por el Máximo Común Divisor (MCD)
                int mcd = ObtenerMCD(Math.Abs(numResta), Math.Abs(denResta));
                numResta /= mcd;
                denResta /= mcd;

                if (denResta < 0)
                {
                    numResta = -numResta;
                    denResta = -denResta;
                }

                Console.WriteLine(denResta == 1 ? $"Resultado: {numResta}" : $"Resultado: {numResta}/{denResta}");
            }
        }

        private bool ProcesarFraccion(string entrada, out int numerador, out int denominador)
        {
            numerador = 0;
            denominador = 1;

            string[] partes = entrada.Split('/');
            if (partes.Length == 1 && int.TryParse(partes[0].Trim(), out numerador))
            {
                return true;
            }
            if (partes.Length == 2 &&
                int.TryParse(partes[0].Trim(), out numerador) &&
                int.TryParse(partes[1].Trim(), out denominador))
            {
                return true;
            }

            return false;
        }

        private int ObtenerMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
    }
}