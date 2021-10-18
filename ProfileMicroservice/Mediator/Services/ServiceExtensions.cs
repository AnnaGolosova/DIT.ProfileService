using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Meditor
{
    public static class ServiceExtensions
    {
        public static void ConfigureMediator(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
