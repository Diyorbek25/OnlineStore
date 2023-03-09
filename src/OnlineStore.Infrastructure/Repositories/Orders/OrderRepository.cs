using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Orders;

public class OrderRepository : GenericRepository<Order, int>, IOrderRepository
{
    public OrderRepository(AppDbContext dbContext)
        : base(dbContext)
    {
    }
}
