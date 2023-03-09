using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrastructure.Contexts;
using System.Linq.Expressions;

namespace OnlineStore.Infrastructure.Repositories;

public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey>
    where TEntity : class
{
    private readonly AppDbContext dbContext;

    public GenericRepository(AppDbContext dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var entityEntry = await this.dbContext
            .AddAsync<TEntity>(entity);
        
        await this.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public IQueryable<TEntity> SelectAll() => 
        this.dbContext.Set<TEntity>();

    public async Task<TEntity> SelectByIdAsync(TKey id) =>
        await this.dbContext.FindAsync<TEntity>(id);
        

    public async Task<TEntity> SelectByIdWithDetailsAsync(
        Expression<Func<TEntity, bool>> expression, 
        string[] includes)
    {
        IQueryable<TEntity> entities = this.SelectAll();

        foreach (var include in includes)
        {
            entities = entities.Include(include);
        }

        return await entities.FirstOrDefaultAsync(expression);
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entityEntry = this.dbContext.Set<TEntity>()
            .Update(entity);

        await this.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<TEntity> DeleteAsync(TEntity entity)
    {
        var entityEntry = this.dbContext.Set<TEntity>()
            .Remove(entity);

        await this.SaveChangesAsync();

        return entityEntry.Entity;
    }

    public async Task<int> SaveChangesAsync() => 
        await this.dbContext.SaveChangesAsync();
}
