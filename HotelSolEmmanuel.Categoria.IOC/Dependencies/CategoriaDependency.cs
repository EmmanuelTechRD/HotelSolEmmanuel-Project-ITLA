
using HotelSolEmmanuel.Categoria.Persistence.Interfaces;
using HotelSolEmmanuel.Categoria.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelSolEmmanuel.Categoria.IOC.Dependencies
{
    public static class CategoriaDependency
    {
        public static void AddCategoriaDependency(this ServiceCollection service)
        {
            #region"Repositorios"
            service.AddScoped<ICategoriaRepository, CategoriaRepository>();
            #endregion

            #region"Services"
            //service.AddTransient<IRoomService, RoomDependency>();
            #endregion
        }
    }
}
