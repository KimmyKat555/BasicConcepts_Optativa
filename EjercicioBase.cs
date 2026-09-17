namespace BasicConcepts_Optativa
{
    public abstract class EjercicioBase
    {
        public string Nombre { get; protected set; } = string.Empty;
        public abstract void Ejecutar();
    }
}