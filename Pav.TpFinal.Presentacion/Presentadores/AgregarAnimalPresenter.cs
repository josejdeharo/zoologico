using Pav.TpFinal.Presentacion.Interfaces;
using System.Diagnostics;

namespace Pav.TpFinal.Presentacion.Presentadores;

public class AgregarAnimalPresenter : PresenterBase<IAgregarAnimalView>
{
    public AgregarAnimalPresenter(IAgregarAnimalView vista, Navigator navigator) : base(vista, navigator)
    {
        
    }
}
