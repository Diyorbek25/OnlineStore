using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.ShoppingCarts;

public class ShoppingCartItemRepository : GenericRepository<ShoppingCartItem, int>, IShoppingCartItemRepository
{
    public ShoppingCartItemRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
