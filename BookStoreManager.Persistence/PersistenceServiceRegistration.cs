using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BookStoreManager.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        
        return services;
    }
}