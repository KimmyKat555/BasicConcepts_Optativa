namespace BasicConcepts_Optativa
{
    // Ejercicio 5: Midweek Day
    public class MidweekDay : EjercicioBase
    {
        public MidweekDay()
        {
            Nombre = "Midweek Day";
        }

        public override void Ejecutar()
        {
            Console.Write("Ingrese un número entre 1 y 7: ");

            if (!int.TryParse(Console.ReadLine() ?? "", out int dia))
            {
                Console.WriteLine("Entrada no válida. Debe ingresar un número entero.");
                return;
            }

            switch (dia)
            {
                case 1:
                    Console.WriteLine("Resultado: Lunes");
                    break;
                case 2:
                    Console.WriteLine("Resultado: Martes");
                    break;
                case 3:
                    Console.WriteLine("Resultado: Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Resultado: Jueves");
                    break;
                case 5:
                    Console.WriteLine("Resultado: Viernes");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Resultado: Número fuera del rango laboral.");
                    break;
                default:
                    Console.WriteLine("Resultado: Número fuera de rango.");
                    break;
            }
        }
    }
}