namespace BasicConcepts_Optativa
{
    // Ejercicio 10: String Length
    public class StringLength : EjercicioBase
    {
        public StringLength()
        {
            Nombre = "String Length";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese una palabra o texto: ");
            string entrada = Console.ReadLine() ?? "";

            // .Trim() elimina espacios innecesarios al inicio y final
            int longitud = entrada.Trim().Length;

            Console.WriteLine($"Resultado: {longitud}");
        }
    }
}