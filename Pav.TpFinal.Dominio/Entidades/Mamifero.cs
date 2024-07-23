using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pav.TpFinal.Dominio.Entidades;

public abstract class Mamifero : EntityBase
{
    protected Mamifero(TipoAlimentacion tipoAlimentacion)
    {
        TipoAlimentacion = tipoAlimentacion;
    }

    public string? Nombre { get; set; }
    public int Edad { get; set; }
    public double Peso { get; set; }
    public TipoAlimentacion TipoAlimentacion { get; }
    public Guid? EspecieId { get; set; }
    public Guid? SectorId { get; set; }
    public Guid? PaisId { get; set; }
    public Especie? Especie { get; set; }
    public Sector? Sector { get; set; }
    public Pais? Origen { get; set; }
}
