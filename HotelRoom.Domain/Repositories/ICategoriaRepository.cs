
using Hotel.Room.Domain.Entities;

namespace Hotel.Room.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<Categoria> GetCategoriaByIdAsync(int id);
        Task<IEnumerable<Categoria>> GetAllCategoriasAsync();
    }
}
