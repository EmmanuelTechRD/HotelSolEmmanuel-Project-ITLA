using HotelSolEmmanuel.Cliente.Domain.Entities;

namespace HotelSolEmmanuel.Cliente.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<IClienteRepository> GetClienteByIdAsync(int id);
        Task<IEnumerable<IClienteRepository>> GetAllClientesAsync();
    }
}
