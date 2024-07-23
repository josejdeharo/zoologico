using Pav.TpFinal.Presentacion.Enums;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas;

/// <summary>
/// Implementación base de la interfaz <see cref="IView"/> para formularios de Windows.
/// Esta clase sirve para ser heredada.
/// <para>
/// Se recomienda el uso de la versión genérica de la clase <see cref="ViewBase{T}"/>
/// con asociación fuertemente tipada al presentador.
/// </para>
/// </summary>
public abstract class ViewBase : Form, IView
{
    protected ViewBase()
    {
        FormClosed += ViewBase_FormClosed;
    }
    /// <summary>
    /// Propiedad para acceder al presentador desde la vista. Implementaciónd de <see cref="IView.Presentador"/>
    /// </summary>
    public virtual IPresenter? Presentador { get; set; }
    /// <summary>
    /// Propiedad que determina si la vista es un contenedor MDI
    /// </summary>
    public bool IsMdiPadre => IsMdiContainer;

    public event EventHandler? VistaClosed;

    /// <summary>
    /// Implementación de <see cref="IView.Mostrar(IView)"/>
    /// </summary>
    public void Mostrar(IView? padre = null)
    {
        if (padre != null && !IsMdiContainer)
        {
            MdiParent = (Form)padre;
        }
        Show();
    }

    /// <summary>
    /// Implementación de <see cref="IView.MostrarComoDialogo"/>
    /// </summary>
    public void MostrarComoDialogo()
    {
        ShowDialog();
    }

    public bool MostrarConfirmacion(string mensaje)
    {
        return MessageBox.Show(mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
    }

    public void MostrarMensaje(string descripcion, Mensaje tipo)
    {
        MessageBox.Show(descripcion, tipo.ToString(), MessageBoxButtons.OK, EstablecerIcono(tipo));
    }

    private MessageBoxIcon EstablecerIcono(Mensaje tipo)
    {
        return tipo switch
        {
            Mensaje.EXITO => MessageBoxIcon.Information,
            Mensaje.ADVERTENCIA => MessageBoxIcon.Warning,
            _ => MessageBoxIcon.Error,
        };
    }

    private void ViewBase_FormClosed(object? sender, FormClosedEventArgs e)
    {
        VistaClosed?.Invoke(this, e);
        Presentador = null;
        Dispose();
    }
}
