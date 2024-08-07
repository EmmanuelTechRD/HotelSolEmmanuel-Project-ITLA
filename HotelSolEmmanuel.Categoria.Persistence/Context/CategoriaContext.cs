using Microsoft.EntityFrameworkCore;

namespace HotelSolEmmanuel.Categoria.Persistence.Context
{
    public class CategoriaContext : DbContext
    {
        #region "Constructor"
        public CategoriaContext(DbContextOptions<CategoriaContext> options) : base(options)
        {

        }
        #endregion

        #region  "Db Sets"
        public DbSet<Domain.Entities.Categoria> Categoria { get; set; }
        #endregion
    }
}
