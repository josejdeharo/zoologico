using Pav.TpFinal.Presentacion.Interfaces;

namespace Pav.TpFinal.Presentacion.Presentadores;

/// <summary>
/// Implementación simple de la interfaz <see cref="IPresenter"/>.
/// Los miembros se definen como virtuales para poder ser sobreescritos en las clases derivadas.
/// <para>
/// Se recomienda el uso de la versión genérica de la clase <see cref="PresenterBase{View}"/>
/// con asociaciones fuertemente tipadas.
/// </para>
/// </summary>
public class PresenterBase : IPresenter
{
    /// <summary>
    /// Propiedad que representa la vista asociada al presentador.
    /// Puede ser sobreescrita en las clases derivadas <see cref="IPresenter.Vista"/>
    /// </summary>
    public virtual IView? Vista { get; set; }
    /// <summary>
    /// Asocia al presentador con el navegador <see cref="Navigator"/> para el desplazamiento
    /// entre navegadores
    /// </summary>
    public Navigator? Navigator { get; set; }

    //Implementación del patrón Dispose básico
    #region Dispose
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            Vista = null;
        }
    }
    #endregion
}
