using HotelSolEmmanuel.Categoria.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSolEmmanuel.Categoria.API.DAL
{
    public class MyAppDbContext : DbContext
    {
        public MyAppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Categoria> MyProperty { get; set; }
    }
}
