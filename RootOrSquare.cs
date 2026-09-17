namespace BasicConcepts_Optativa
{
    //Ejercicio 3:Root or Square
    public class RootOrSquare : EjercicioBase
    {
        public RootOrSquare()
        {
            Nombre = "Root or Square";
        }
        
        public override void Ejecutar()
        {
            Console.Write("Ingrese un número: ");
            if(!double.TryParse(Console.ReadLine()?? "", out double numero))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número");
                return;
            }

            if (numero > 0)
            {
                double raiz = Math.Sqrt(numero);
                Console.WriteLine($"Resultado: {raiz}");
            }
            else if (numero < 0)
            {
                double cuadrado = numero * numero; 
                Console.WriteLine($"Resultado: {cuadrado}");
            }
            else
            {
                Console.WriteLine("Resultado: 0");
            }
        }
    }
}