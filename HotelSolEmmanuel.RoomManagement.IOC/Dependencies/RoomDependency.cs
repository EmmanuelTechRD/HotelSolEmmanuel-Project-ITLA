using Hotel.Room.Persistence.Interfaces;
using Hotel.Room.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelSolEmmanuel.RoomManagement.IOC.Dependencies
{
    public static class RoomDependency
    {
        public static void AddRoomDependency(this ServiceCollection service)
        {
            #region"Repositorios"
            service.AddScoped<ICategoriaRepository, CategoriaRepository>();
            service.AddScoped<IClienteRepository, ClienteRepository>();
            #endregion

            #region"Services"
            //service.AddTransient<IRoomService, RoomDependency>();
            #endregion
        }
    }
}
