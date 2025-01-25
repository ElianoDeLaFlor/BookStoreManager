using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence.DatabaseContext;
using BookStoreManager.Persistence.Dtos;
using BookStoreManager.Persistence.RepositoriesInterfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;


namespace BookStoreManager.Persistence;

public static class PersistenceServiceRegistration
{
    public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration Configuration)
    {
        services.AddAutoMapper(typeof(EntityMapperProfile));
        
        // Register DbContext with dependency injection
        
        services.AddDbContext<DataContext>((serviceProvider, options) =>
        {
            var dbSettings = serviceProvider.GetRequiredService<IOptions<DbConfigOptions>>().Value;

            if (dbSettings.Provider == "SqlServer")
            {
                options.UseSqlServer(dbSettings.ConnectionString);
            }
            else
            {
                throw new Exception("Unsupported database provider.");
            }
        });


        services.AddScoped<IDataContext, DataContext>();
        
        return services;
    }
}