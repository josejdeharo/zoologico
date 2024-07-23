
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Interfaces
{
    /// <summary>
    /// Extensión genérica de la interfaz <see cref="IView"/>.
    /// Tiene una asociación fuertemente tipada al presentador.
    /// <para>
    /// En vez de implementar esta interfaz directamente conviene heredar
    /// de la clase base <see cref="VistaBase{T}"/> que implementa esta interfaz.
    /// </para>
    /// </summary>
    /// <typeparam name="T">Tipo esperado del presentador asociado. Debe ser un subtipo
    /// de <see cref="IPresenter"/></typeparam>
    public interface IView<T> : IView
        where T : IPresenter
    {
        /// <summary>
        /// Propiedad para acceder al presentador asociado.
        /// <para>
        /// Utiliza la palabra reservada new para reutilizar el nombre de la propiedad
        /// definido en la interfaz <see cref="IView"/>
        /// </para>
        /// </summary>
        new T? Presentador { get; set; }
    }
}
