using BookStoreManager.Persistence.Dtos;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace BookStoreManager.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddAutoMapper(typeof(EntityMapperProfile));
        
        return services;
    }
}