using System.Linq.Expressions;

namespace OnlineStore.Infrastructure.Repositories;

public interface IGenericRepository<TEntity, TKey>
{
    Task<TEntity> InsertAsync(TEntity entity);
    IQueryable<TEntity> SelectAll();
    Task<TEntity> SelectByIdAsync(TKey id);

    Task<TEntity> SelectByIdWithDetailsAsync(
        Expression<Func<TEntity, bool>> expression,
        string[] includes);

    Task<TEntity> UpdateAsync(TEntity entity);
    Task<TEntity> DeleteAsync(TEntity entity);
    Task<int> SaveChangesAsync();
}
