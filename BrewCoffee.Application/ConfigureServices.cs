using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace BrewCoffee.Application
{
    public static class ConfigureSefrvices
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // Register MediatR
            services.AddMediatR(x => x.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }
    }
}
