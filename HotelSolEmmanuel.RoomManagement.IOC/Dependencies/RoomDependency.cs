using Hotel.Room.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelSolEmmanuel.RoomManagement.IOC.Dependencies
{
    public static class RoomDependency
    {
        public static void AddRoomDependency(this ServiceCollection service)
        {
            #region"Repositorios"
            service.AddScoped<IHotelRepository, IHotelRepository>();
            service.AddScoped<IRoomRepository, IRoomRepository>();
            #endregion

            #region"Services"
            service.AddTransient<IRoomService, RoomDependency>();
            #endregion
        }
    }
}
