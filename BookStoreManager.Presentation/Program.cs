using BookStoreManager.Domain.Models;
using BookStoreManager.Persistence;
using Microsoft.EntityFrameworkCore;

namespace BookStoreManager.Presentation;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        builder.Services.AddOptions<DbConfigOptions>().BindConfiguration("DbConfig");
        builder.Services.Configure<DbConfigOptions>(
            builder.Configuration.GetSection("DbConfig")
        );

        
        builder.Services.AddPersistenceServices(builder.Configuration);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}