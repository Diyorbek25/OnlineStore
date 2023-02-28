using Microsoft.EntityFrameworkCore;

namespace OnlineStore.Infrastructure.Contexts;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options)
		: base(options)
	{
	}
}
