using Microsoft.Extensions.DependencyInjection;
using POS.Domain.Repositories;

namespace POS.Domain
{
    public static class DependencyInjection
    {
        public static void AddDomainLayer(this IServiceCollection services)
        {
            // DependencyInjection
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}