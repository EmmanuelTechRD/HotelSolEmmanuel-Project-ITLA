

using HotelSolEmmanuel.Categoria.Application.Interfaces;
using HotelSolEmmanuel.Categoria.Application.Services;
using HotelSolEmmanuel.Categoria.Domain.Interfaces;
using HotelSolEmmanuel.Categoria.Persistence.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace HotelSolEmmanuel.Categoria.IOC.Dependencies
{
    public static class CategoriaDependency
    {
        public static void addCategoriaDependency(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ICategoriaService, CategoriaService>();
        }
    }
}
