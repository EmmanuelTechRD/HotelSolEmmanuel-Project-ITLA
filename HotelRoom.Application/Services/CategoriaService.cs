using Hotel.Room.Domain.Repositories;
using Hotel.Room.Domain.Entities;

namespace Hotel.Room.Application.Services
{
    public class CategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public async Task<CategoriaDto> GetCategoriaByIdAsync(int id)
        {
            var categoria = await _categoriaRepository.GetCategoriaByIdAsync(id);
            return new CategoriaDto { IdCategoria = categoria.IdCategoria, Descripcion = categoria.Descripcion };
        }
    }
}
