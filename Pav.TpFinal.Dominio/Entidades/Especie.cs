

namespace Pav.TpFinal.Dominio.Entidades;

public class Especie : EntityBase
{
    public int Codigo { get; init; }
    public string? Nombre { get; init; }
    public double PorcentajePesoCarne { get; init; }

    public TipoAlimentacion TipoAlimentacion { get; init; }
}
