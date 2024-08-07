
using HotelSolEmmanuel.Common.Data.Repository;

namespace HotelSolEmmanuel.Categoria.Domain.Interfaces
{
    public interface ICategoriaRepository : IBaseRepository<Domain.Entities.Categoria, int>
    {
        List<Domain.Entities.Categoria> GetCategoriasByIdCategoria(int IdCategoria);
    }
}
