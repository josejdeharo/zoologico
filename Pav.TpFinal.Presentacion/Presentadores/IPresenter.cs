
using Pav.TpFinal.Presentacion.Interfaces;

namespace Pav.TpFinal.Presentacion.Presentadores;

/// <summary>
/// Todos los presentadores deben implementar la interfaz.
/// En la práctica es más útil heredar de <see cref="PresenterBase"/> 
/// o la versión genérica <see cref="PresenterBase{View}"/> que
/// implementan los miembros de IPresentador.
/// </summary>
public interface IPresenter: IDisposable
{
    /// <summary>
    /// Enlaza al presentador con su vista. De acuerdo al patrón MVP, el presentador
    /// accede a su vista.
    /// <para>
    /// El método setter de la propiedad Vista se puede utilizar para inicializar lo
    /// necesario en la vista.
    /// <code>
    /// class MiPresentador : PresentadorBase
    /// {
    ///     public override IVista Vista
    ///     {
    ///         get { return base.Vista; }
    ///         set
    ///         {
    ///             base.Vista = value;
    ///             //Inicializar lo necesario en la vista
    ///         }
    ///     }
    /// }
    /// </code>
    /// </para>
    /// </summary>
    IView? Vista { get; set; }
    /// <summary>
    /// Asocia al presentador con el navegador <see cref="Navigator"/> para el desplazamiento
    /// entre navegadores
    /// </summary>
    Navigator? Navigator { get; set; }
}
