using OnlineStore.Domain.Entities;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Infrastructure.Repositories.Users;

public class UserRepositor : GenericRepository<User, int>, IUserRepository
{
    public UserRepositor(AppDbContext dbContext) 
        : base(dbContext)
    {
    }
}
