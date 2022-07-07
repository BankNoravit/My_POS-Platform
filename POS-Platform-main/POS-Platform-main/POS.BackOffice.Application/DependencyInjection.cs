using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace POS.Application
{
    public static class DependencyInjection
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            services.AddV1();
            services.AddV2();
            services.AddV3();
        }

        public static void AddV1(this IServiceCollection services)
        {
            // DependencyInjection
            //services.AddSingleton<IXXXX, XXXX>();
        }

        public static void AddV2(this IServiceCollection services)
        {
            // DependencyInjection
            //services.AddSingleton<IXXXX, XXXX>();
        }

        public static void AddV3(this IServiceCollection services)
        {
            // DependencyInjection
            //services.AddSingleton<IXXXX, XXXX>();
        }
    }
}