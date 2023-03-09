using OnlineStore.Domain.Entities;

namespace OnlineStore.Infrastructure.Repositories.Orders;

public interface IOrderRepository : IGenericRepository<Order, int>
{
}
