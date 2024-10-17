using Architecture.IdentityUser;
using Architecture.Toppings.Command.AddToppingCommand;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Architecture.Extensions
{
    //static class to work on services
    public static class ServiceCollectionExtension
    {
        // this static exntensions is addin to DI container architecture
        public static void AddArchitecture(this IServiceCollection services, IConfiguration config)
        {
            services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
            services.AddMediatR(config =>
            {
                config.RegisterServicesFromAssembly(typeof(AddToppingCommand).Assembly);
            });
        }
    }
}
