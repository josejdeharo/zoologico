using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class PrincipalView : PrincipalViewWithPresenter, IPrincipalView
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        public event EventHandler AgregarAnimalClicked
        {
            add { agregarAnimalToolStripMenuItem.Click += value; }
            remove { agregarAnimalToolStripMenuItem.Click -= value; }
        }
    }

    public class PrincipalViewWithPresenter : ViewBase<PrincipalPresenter> { }
}
