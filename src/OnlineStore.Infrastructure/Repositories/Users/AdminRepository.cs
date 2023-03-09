using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Users;

public class AdminRepository : GenericRepository<Admin, int>, IAdminRepository
{
    public AdminRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
