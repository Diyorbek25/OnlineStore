using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Repositories.Products;

public interface IProductRepository : IGenericRepository<Product, int>
{
}
