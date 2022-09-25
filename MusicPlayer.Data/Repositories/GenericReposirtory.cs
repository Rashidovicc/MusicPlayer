
using Microsoft.EntityFrameworkCore;
using MusicPlayer.Data.DbContexts;
using MusicPlayer.Data.IRepositories;
using System.Linq.Expressions;

namespace MusicPlayer.Data.Repositories
{
    public class GenericReposirtory<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly MusicDbCotnext dbCotnext;
        protected readonly DbSet<TEntity> dbSet;
        public GenericReposirtory(MusicDbCotnext dbCotnext)
        {
            this.dbCotnext = dbCotnext;
            this.dbSet = this.dbCotnext.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
            => (await this.dbSet.AddAsync(entity)).Entity;

        public void Delete(TEntity entity)
            => this.dbSet.Remove(entity);

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>>? expression = null)
            => expression is null ? this.dbSet : this.dbSet.Where(expression);

        public async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>> expression)
            => await this.dbSet.FirstOrDefaultAsync(expression);

        public TEntity Update(TEntity entity)
            => (this.dbSet.Update(entity)).Entity;
    }
}
