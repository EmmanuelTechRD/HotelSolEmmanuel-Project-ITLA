using HotelSolEmmanuel.Categoria.Domain.Interfaces;
using HotelSolEmmanuel.Categoria.Persistence.Context;
using Microsoft.Extensions.Logging;
using System.Linq.Expressions;

namespace HotelSolEmmanuel.Categoria.Persistence.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly CategoriaContext context;
        private readonly ILogger<CategoriaRepository> logger;
        public CategoriaRepository(CategoriaContext context, ILogger<CategoriaRepository> logger)
        {
            this.context = context;
            this.logger = logger;
        }

        public bool Exists(Expression<Func<Domain.Entities.Categoria, bool>> filter)
        {
            return context.Categoria.Any(filter);
        }

        public List<Domain.Entities.Categoria> GetAll()
        {
            return context.Categoria.ToList();
        }

        public Domain.Entities.Categoria GetEntityBy(int Id)
        {
            return context.Categoria.Find(Id);
        }

        public List<Domain.Entities.Categoria> GetCategoriasByIdCategoria(int Id)
        {
            return context.Categoria.Where(r => r.Id == Id).ToList();
        }

        public void Save(Domain.Entities.Categoria entity)
        {
            try
            {
                this.context.Categoria.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al guardar la Categoria.", ex);
            }
        }

        public void Update(Domain.Entities.Categoria entity)
        {
            try
            {
                this.context.Categoria.Update(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al modificar la Categoria.", ex);
            }
        }

        public void Remove(Domain.Entities.Categoria entity)
        {
            try
            {
                this.context.Categoria.Remove(entity);
                this.context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw new Exception("Error al eliminar la Categoria.", ex);
            }
        }
    }
}
