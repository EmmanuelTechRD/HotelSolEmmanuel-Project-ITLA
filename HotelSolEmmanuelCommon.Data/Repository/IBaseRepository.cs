
using System.Linq.Expressions;

namespace HotelSolEmmanuel.Common.Data.Repository
{
    public interface IBaseRepository<TEntity, TType> where TEntity : class
    {
        List<TEntity> GetAll();

        TEntity GetAllBy(TType id);
        void Save(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);

        bool Exist(Expression<Func<TEntity, bool>> filter);
    }
}
