using Microsoft.EntityFrameworkCore;
using OnlineStore.Infrastructure.Contexts;

namespace OnlineStore.Api.Extensions;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddInfrastructre(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        string connectionString = configuration
            .GetConnectionString("SqlServer");

        services.AddDbContextPool<AppDbContext>(options =>
        {
            options.UseSqlServer(connectionString);
        });

        return services;
    }
}
