
namespace HotelSolEmmanuel.Categoria.Domain.Repositories
{
    public interface ICategoriaRepository
    {
        Task<ICategoriaRepository> GetCategoriaByIdAsync(int id);
        Task<IEnumerable<ICategoriaRepository>> GetAllCategoriasAsync();
    }
}
