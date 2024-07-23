using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas;

/// <summary>
/// Implementación base de la interfaz <see cref="IView{T}"/> para formularios de Windows.
/// Tiene una asociación fuertemente tipada al presentador. Esta clase sirve para ser heredada.
/// <para>
/// Se recomienda el uso de esta clase para heredar en los formularios de Windows.
/// </para>
/// </summary>
public abstract class ViewBase<T> : ViewBase, IView<T>
    where T : class, IPresenter
{
    /// <summary>
    /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IView{T}.Presentador"/>
    /// </summary>
    public new T? Presentador { get; set; }

    /// <summary>
    /// Implementación de <see cref="IView.Presentador"/> 
    /// como puerta de enlace la propiedad fuertemente tipada
    /// <see cref="IView{T}.Presentador"/>
    /// </summary>
    IPresenter? IView.Presentador
    {
        get { return Presentador; }
        set { Presentador = value as T; }
    }
}
