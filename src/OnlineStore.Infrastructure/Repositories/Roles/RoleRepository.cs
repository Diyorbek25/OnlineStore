using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Roles;

public class RoleRepository : GenericRepository<Role, int>, IRoleRepository
{
    public RoleRepository(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
