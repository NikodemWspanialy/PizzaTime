using Architecture.IdentityUser;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecture.Extensions
{
    //static class to work on services
    public static class ServiceCollectionExtension
    {
        // this static exntensions is addin to DI container architecture
        public static void AddArchitecture(this IServiceCollection services, IConfiguration config)
        {
           services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();
        }
    }
}
