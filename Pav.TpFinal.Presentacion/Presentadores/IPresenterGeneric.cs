namespace Pav.TpFinal.Presentacion.Presentadores;

/// <summary>
/// Extensión genérica de la interfaz <see cref="IPresenter"/>.
/// Tiene asociación fuertemente tipada a la vista para evitar conversiones de tipos.
/// <para>
/// En vez de implementar esta interfaz directamente conviene heredar de la clase
/// <see cref="PresenterBase{Vista}"/> que la implementa.
/// </para>
/// </summary>
/// <typeparam name="TView">Representa el tipo de la vista asociada.</typeparam>
public interface IPresenter<TView> : IPresenter
    where TView : class
{
    /// <summary>
    /// Propiedad para acceder a la vista asociada al tipo genérico.
    /// <para>
    /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
    /// definido en la interfaz <see cref="IPresenter"/>
    /// </para>
    /// </summary>
    new TView? Vista { get; set; }
}
