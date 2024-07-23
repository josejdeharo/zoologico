namespace Pav.TpFinal.Dominio.Entidades;

public class Sector : EntityBase
{
    public Sector()
    {
        Animales = new List<Mamifero>();
    }

    public int Numero { get; init; }
    public double Latitud { get; init; }
    public double Longitud { get; init;}
    public int Limite { get; init; }
    public TipoAlimentacion TipoAlimentacion { get; init; }
    public Guid? EmpleadoId { get; init; }
    public Empleado? Empleado { get; init; }
    public List<Mamifero> Animales { get; }

    public override string ToString() => $"[{Numero}] {TipoAlimentacion}";
    
}
