using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Pav.TpFinal.Infraestructura.Datos;

internal class PavFinalContextFactory : IDesignTimeDbContextFactory<PavTpFinalContext>
{
    public PavTpFinalContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<PavTpFinalContext>();
        optionsBuilder.UseSqlServer(PavTpFinalContext.CadenaDeConexion);

        return new PavTpFinalContext(optionsBuilder.Options);
    }
}