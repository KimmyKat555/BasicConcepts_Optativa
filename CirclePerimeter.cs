namespace BasicConcepts_Optativa
{
    //ejercicio 4: circle perimeter
    public class CirclePerimeter: EjercicioBase
    {
        public CirclePerimeter()
        {
            Nombre = "Circle Perimeter"; 
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese el radio del círculo: ");

            if(!double.TryParse(Console.ReadLine()?? "", out double radio))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número.");
                return;
            }
            if (radio < 0)
            {
                Console.WriteLine("El radio no puede ser negativo.");
                return;
            }

            // formula para perimetro
            double perimetro = 2 * Math.PI * radio;

            // formateado a dos decimales segun los casos de prueba
            Console.WriteLine($"Resultado: {Math.Round(perimetro,2)}");
        }
    }
}