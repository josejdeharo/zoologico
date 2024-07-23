
using Pav.TpFinal.Dominio.Entidades;
namespace Pav.TpFinal.Infraestructura.Datos.Datos;

public class Repositorio
{
    private static Repositorio? _instance = null;
    private static readonly object _lock = new();

    private Repositorio()
    {
        Inicializar();
    }

    public static Repositorio Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance = new Repositorio();
                }
            }
            return _instance;
        }
    }

    public List<Sector> Sectores { get; } = new List<Sector>();
    public List<Pais> Paises { get; } = new List<Pais>();
    public List<Especie> Especies { get; } = new List<Especie>();
    public List<Empleado> Empleados { get; } = [];

    private void Inicializar()
    {
        InicializarPaises();
        InicializarEspecies();
        InicializarSectores();
    }

    private void InicializarPaises()
    {
        Paises.AddRange(new[]
        {
            new Pais
            {
                Id = Guid.NewGuid(),
                Nombre = "Sudáfrica"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Nombre = "Australia"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Nombre = "Singapur"
            },
            new Pais
            {
                Id = Guid.NewGuid(),
                Nombre = "Canadá"
            }
        });
    }

    private void InicializarEspecies()
    {
        Especies.AddRange(new[]
        {
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 1,
                Nombre = "León",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.7
            },
            new Especie
            {
                Id = Guid.NewGuid(),
                Codigo = 2,
                Nombre = "Jirafa",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            },
            new Especie
            {Id = Guid.NewGuid(),
                Codigo = 3,
                Nombre = "Tigre",
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                PorcentajePesoCarne = 0.5
            },
            new Especie
            {Id = Guid.NewGuid(),
                Codigo = 4,
                Nombre = "Rinoceronte",
                TipoAlimentacion = TipoAlimentacion.HERBIVORO
            }
        });
    }

    private void InicializarSectores()
    {
        var empleado1 = new Empleado
        {
            Id = Guid.NewGuid(),
            Nombre = "Luis",
            Documento = "12345678",
            Domicilio = "Tucumán"
        };
        var empleado2 = new Empleado
        {
            Id = Guid.NewGuid(),
            Nombre = "María",
            Documento = "87654321",
            Domicilio = "Tucumán"
        };
        Empleados.Add(empleado1);
        Empleados.Add(empleado2);
        Sectores.AddRange(new[]
        {
            new Sector
            {Id = Guid.NewGuid(),
                Numero = 1,
                Latitud =-26.250724,
                Longitud = -65.522827,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                EmpleadoId = empleado1.Id
            },
            new Sector
            {Id = Guid.NewGuid(),
                Numero = 2,
                Latitud =-26.252359,
                Longitud = -65.521511,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                EmpleadoId = empleado1.Id
            },
            new Sector
            {Id = Guid.NewGuid(),
                Numero = 3,
                Latitud =-26.254661,
                Longitud = -65.522726,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.HERBIVORO,
                EmpleadoId = empleado2.Id
            },
            new Sector
            {Id = Guid.NewGuid(),
                Numero = 4,
                Latitud =-26.257250,
                Longitud = -65.523514,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                EmpleadoId = empleado2.Id
            },
            new Sector
            {Id = Guid.NewGuid(),
                Numero = 5,
                Latitud =-26.257250,
                Longitud = -65.523514,
                Limite = 10,
                TipoAlimentacion = TipoAlimentacion.CARNIVORO,
                EmpleadoId = empleado2.Id
            }
        });
    }
}

