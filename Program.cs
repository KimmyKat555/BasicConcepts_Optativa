EjercicioBase ej2 = new DoubleOrTriple();
ej2.Ejecutar();

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
        //Validacion de entrada
        if (!double.TryParse(Console.ReadLine(), out _numero))
        {
            Console.WriteLine("Entrada no válida. Debe ingresar un numero.");
            return;
        }
        //Logica del ejercicio
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

//Ejercicio 2 Double or Triple
public class DoubleOrTriple : EjercicioBase
{
    private double _primerNumero;
    private double _segundoNumero;

    public DoubleOrTriple()
    {
        Nombre = "Double or Triple";
    }

    public override void Ejecutar()
    {
        //Solicitar y validar el primer numero
        Console.Write("Ingrese el primer numero: ");
        if (!double.TryParse(Console.ReadLine(), out _primerNumero))
        {
            Console.WriteLine("Entrada no válida para el primer número.");
            return;
        }

        //Solicitar y validar el segundo numero
        Console.Write("Ingrese el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out _segundoNumero))
        {
            Console.WriteLine("Entrada no válida para el segundo número.");
            return;
        }
        //Evaluar las condiciones
        if (_primerNumero > _segundoNumero)
        {
            double resultado = _primerNumero * 2;
            Console.WriteLine($"Resultado: {resultado}");
        }
        else
        {
            double resultado = _segundoNumero * 3;
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}