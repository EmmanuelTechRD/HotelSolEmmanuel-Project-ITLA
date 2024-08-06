
using System.Linq.Expressions;

namespace HotelSolEmmanuel.Common.Data.Repository
{
    // Interfaz base para el repositorio de datos
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetEntityBy(TType Id);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        bool Exists(Expression<Func<TEntity, bool>> filter);
    }
}
