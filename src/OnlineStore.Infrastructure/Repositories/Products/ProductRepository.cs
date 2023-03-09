using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Products;

public class ProductRepository : GenericRepository<Product, int>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
