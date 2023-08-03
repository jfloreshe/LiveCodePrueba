using Microsoft.EntityFrameworkCore;
using RoleBased.Data;

namespace RoleBased;

public static class WebApiServices
{
    public static void ConfigureWebApiServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<RoleBasedContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("RBContext"))
            );
    }
}
