EjercicioBase ej1 = new PositivePower();
ej1.Ejecutar();

//Clase base abstracta
public abstract class EjercicioBase
{
    public string Nombre {get; protected set;}
    public abstract void Ejecutar();
}

//Ejercicio 1 Positive Power
public class PositivePower : EjercicioBase
{
    private double _numero;
    public PositivePower()
    {
        Nombre = "Positive power";
    }

    public override void Ejecutar()
    {
        Console.Write("Ingrese un numero: ");
        if (!double.TryParse(Console.ReadLine(), out _numero))
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un numero.");
            return;
        }

        if (_numero > 0)
        {
            Console.WriteLine($"Resultado: {_numero * _numero}");
        }
        else if (_numero < 0)
        {
            Console.WriteLine("Resultado: Número negativo.");
        }
        else
        {
            Console.WriteLine("Resultado: 0");
        }
    }

}