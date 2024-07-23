using Pav.TpFinal.Presentacion.Interfaces;

namespace Pav.TpFinal.Presentacion.Presentadores;

public class PrincipalPresenter : PresenterBase<IPrincipalView>
{
    public PrincipalPresenter(IPrincipalView vista, Navigator navigator) : base(vista, navigator)
    {
        Vista!.AgregarAnimalClicked += Vista_AgregarAnimalClicked;
    }

    private void Vista_AgregarAnimalClicked(object? sender, EventArgs e)
    {
        Navigator?.NavegarA<AgregarAnimalPresenter>(true);
    }
}
