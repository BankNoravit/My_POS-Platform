using Microsoft.Extensions.DependencyInjection;

namespace POS.Common
{
    public static class DependencyInjection
    {
        public static void AddCommonLayer(this IServiceCollection services)
        {
            // DependencyInjection
            services.AddScoped<IAzureBlobCommon, AzureBlobCommon>();
            services.AddScoped<IJWTCommon, JWTCommon>();
            services.AddScoped<INLogCommon, NLogCommon>();
            services.AddScoped<IRestCommon, RestCommon>();
            services.AddScoped<ISecurityCommon, SecurityCommon>();
            services.AddScoped<ISendgridEmailCommon, SendgridEmailCommon>();
            services.AddScoped<IUtilityCommon, UtilityCommon>();
        }
    }
}