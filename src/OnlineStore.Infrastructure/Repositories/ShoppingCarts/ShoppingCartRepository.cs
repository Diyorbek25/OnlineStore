using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.ShoppingCarts;

public class ShoppingCartRepository : GenericRepository<ShoppingCart, int>, IShoppingCartRepository
{
    public ShoppingCartRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
