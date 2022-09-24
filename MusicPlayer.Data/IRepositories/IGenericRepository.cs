
using System.Linq.Expressions;

namespace MusicPlayer.Data.IRepositories
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression);
        IQueryable<TEntity> GetAllAsync(Expression<Func<TEntity, bool>>? expression = null);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
