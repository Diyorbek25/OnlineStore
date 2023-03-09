using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Repositories.ShoppingCarts;

public interface IShoppingCartItemRepository : IGenericRepository<ShoppingCartItem, int>
{
}
