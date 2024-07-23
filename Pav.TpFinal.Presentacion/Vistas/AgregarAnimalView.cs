using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;

namespace Pav.TpFinal.Presentacion.Vistas
{
    public partial class AgregarAnimalView : AgregarAnimalViewWithPresenter, IAgregarAnimalView
    {
        public AgregarAnimalView()
        {
            InitializeComponent();
        }

        
    }

    public class AgregarAnimalViewWithPresenter : ViewBase<AgregarAnimalPresenter> { }
}
