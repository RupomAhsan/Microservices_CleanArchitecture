using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Persistence;
public static class StartupSetup
{
    public static void AddLetsRideDbContext(this IServiceCollection services, string connectionString) =>
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(connectionString)); // will be created in web project root
}
