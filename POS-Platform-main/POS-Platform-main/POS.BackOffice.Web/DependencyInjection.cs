using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using POS.BackOffice.Web.Services;

namespace POS.BackOffice.Web
{
    public static class DependencyInjection
    {
        public static void AddServices(this IServiceCollection services)
        {
            // DependencyInjection
            services.AddScoped<IBaseService, BaseService>();
        }
    }
}