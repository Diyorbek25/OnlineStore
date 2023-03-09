using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Orders;

public class OrderItemRepository : GenericRepository<OrderItem, int>, IOrderItemRepository
{
    public OrderItemRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
