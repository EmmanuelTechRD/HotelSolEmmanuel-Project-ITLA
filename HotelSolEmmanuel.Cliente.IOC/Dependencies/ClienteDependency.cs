
using HotelSolEmmanuel.Cliente.Persistence.Interfaces;
using HotelSolEmmanuel.Cliente.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelSolEmmanuel.Cliente.IOC.Dependencies
{
    public static class ClienteDependency
    {
        public static void AddClienteDependency(this ServiceCollection service)
        {
            #region"Repositorios"
            service.AddScoped<IClienteRepository, ClienteRepository>();
            #endregion

            #region"Services"
            //service.AddTransient<IClienteService, ClienteDependency>();
            #endregion
        }
    }
}
