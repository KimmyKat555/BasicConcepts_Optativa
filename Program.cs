namespace BasicConcepts_Optativa
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EjercicioBase> ejercicios = new List<EjercicioBase>
            {
                new PositivePower(),
                new DoubleOrTriple(),
                new RootOrSquare()
            };

            bool salir = false;

            do
            {
                Console.WriteLine("----- Menú de ejercicios -----");

                for (int i = 0; i < ejercicios.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {ejercicios[i].Nombre}");
                }

                Console.WriteLine("0. Salir");
                Console.WriteLine("--------------");
                Console.Write("Seleccione una opción: ");

                string entrada = Console.ReadLine() ?? "";

                if (int.TryParse(entrada, out int opcion))
                {
                    if (opcion == 0)
                    {
                        salir = true;
                        Console.WriteLine("\n¡Hasta luego!");
                    }
                    else if (opcion > 0 && opcion <= ejercicios.Count)
                    {
                        Console.WriteLine($"--- {ejercicios[opcion - 1].Nombre} ---\n");

                        ejercicios[opcion - 1].Ejecutar();

                        Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                        Console.ReadKey();
                    }
                    else
                    {
                        MostrarMensajeError("Opción fuera de rango. Ingrese un número válido.");
                    }
                }
                else
                {
                    MostrarMensajeError("Por favor, ingrese un número entero válido.");
                }

            } while (!salir);
        }

        public static void MostrarMensajeError(string mensaje)
        {
            Console.WriteLine($"\nError: {mensaje}");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}