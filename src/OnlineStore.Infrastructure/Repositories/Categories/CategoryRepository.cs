using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Categories;

public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
{
    public CategoryRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
