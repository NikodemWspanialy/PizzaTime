using Domain.Interfaces.IRepositories;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    //static class to work on services
    public static class ServiceCollectionExtension
    {
        // this static exntensions is addin to DI container, infrastracture interfaces
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("PizzaDB") ?? throw new InvalidOperationException("Connection string 'pizzaDB' not found.");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddIdentityCore<ApplicationUser>(options =>
            {
                //Account options
                options.SignIn.RequireConfirmedAccount = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddSignInManager()
            .AddDefaultTokenProviders();

            //add repositories
            services.AddScoped<IToppingRepository, ToppingRepository>();
        }
    }
}
