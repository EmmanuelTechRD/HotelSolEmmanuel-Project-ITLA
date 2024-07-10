
using Hotel.Room.Domain.Entities;

namespace Hotel.Room.Domain.Repositories
{
    public interface IClienteRepository
    {
        Task<Cliente> GetClienteByIdAsync(int id);
        Task<IEnumerable<Cliente>> GetAllClientesAsync();
    }
}
