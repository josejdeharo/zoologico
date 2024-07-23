
using Pav.TpFinal.Presentacion.Enums;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Interfaces;

/// <summary>
/// Las vistas deben implementar esta interfaz.
/// <para>
/// Por conveniencia se definió la versión genérica <see cref="IView{T}"/>
/// para asociaciones fuertemente tipadas al presentador.
/// </para>   
/// </summary>
public interface IView: IDisposable
{
    /// <summary>
    /// Evento a ser invocado cuando la vista se cierre
    /// </summary>
    event EventHandler? VistaClosed;
    /// <summary>
    /// Propiedad para acceder al presentador desde la vista.
    /// </summary>
    IPresenter? Presentador { get; set; }

    /// <summary>
    /// Propiedad que establece si la vista es un contenedor MDI
    /// </summary>
    bool IsMdiPadre { get; }

    /// <summary>
    /// Método para mostrar un mensaje, pudiendo ser de éxito, error o advertencia
    /// </summary>
    /// <param name="mensaje">Texto del mensaje</param>
    /// <param name="tipo">Tipo de mensaje (éxito, error o advertencia)</param>
    void MostrarMensaje(string mensaje, Mensaje tipo);

    /// <summary>
    /// Método para visualizar la vista.
    /// Si se incluye el argumento en la llamada la vista se inicia como hija.
    /// </summary>
    /// <param name="padre">Vista padre para casos MDI</param>
    void Mostrar(IView? padre = null);

    /// <summary>
    /// Método para visualizar la vista como un cuadro de diálogo.
    /// </summary>
    void MostrarComoDialogo();

    /// <summary>
    /// Método para solicitar confirmación por parte del usuario
    /// </summary>
    /// <param name="mensaje">Texto del mensaje</param>
    /// <returns>True si el usuario confirma. False en el caso contrario</returns>
    bool MostrarConfirmacion(string mensaje);
}
