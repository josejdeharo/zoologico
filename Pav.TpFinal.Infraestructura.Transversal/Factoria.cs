using Microsoft.Extensions.DependencyInjection;

namespace Pav.TpFinal.Infraestructura.Transversal;

/// <summary>
/// Este Singleton funciona como una fábrica, utilizando el contenedor de DI 
/// para resolver (crear) las clases que no pueden ser inyectadas.
/// La clase evita generar una dependencia del contenedor en otras partes de la aplicación.
/// </summary>
public class Factoria
{
    private static volatile Factoria? _instance;
    private static readonly object _syncLock = new(); //para hacer el singleton thread safe

    private ServiceProvider _container;

    private Factoria()
    {

    }

    public static Factoria Instance
    {
        get
        {
            lock (_syncLock)
            {
                return _instance ??= new Factoria();
            }
        }
    }

    public void SetContenedor(ServiceProvider container)
    {
        _container = container;
    }

    public T? Crear<T>()
    {
        return _container.GetService<T>();
    }
}
