using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pav.TpFinal.Infraestructura.Datos;
using Pav.TpFinal.Infraestructura.Transversal;
using Pav.TpFinal.Presentacion.Interfaces;
using Pav.TpFinal.Presentacion.Presentadores;
using Pav.TpFinal.Presentacion.Vistas;

namespace Pav.TpFinal.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var service = new ServiceCollection();
            service
                .AddDbContext<PavTpFinalContext>( options =>
                {
                    options.UseSqlServer(PavTpFinalContext.CadenaDeConexion);
                })
                .AddSingleton<Navigator>()
                .AddTransient<IAgregarAnimalView, AgregarAnimalView>()
                .AddTransient<IPrincipalView, PrincipalView>()
                .AddTransient<PrincipalPresenter>()
                .AddTransient<AgregarAnimalPresenter>();

            using var serviceProvider = service.BuildServiceProvider();
            Factoria.Instance.SetContenedor(serviceProvider);
            Factoria.Instance.Crear<Navigator?>()?.NavegarA<PrincipalPresenter>();
            Application.Run(Application.OpenForms[0]!);
        }
    }
}