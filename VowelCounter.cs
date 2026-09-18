namespace BasicConcepts_Optativa
{
    // Ejercicio 13: Vowel Counter
    public class VowelCounter : EjercicioBase
    {
        public VowelCounter()
        {
            Nombre = "Vowel Counter";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = (Console.ReadLine() ?? "").ToLower();

            int contadorVocales = 0;
            string vocales = "aeiouáéíóúAEIOU";

            foreach (char caracter in palabra)
            {
                if (vocales.Contains(caracter))
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine($"Resultado: {contadorVocales}");
        }
    }
}