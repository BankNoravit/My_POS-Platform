using NLog;
using NLog.Web;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData;
using Microsoft.EntityFrameworkCore;
using POS.Application;
using POS.AppSettings;
using POS.Common;
using POS.BackOffice.WebAPI;
using POS.Domain;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Swashbuckle.AspNetCore.Filters;
using Newtonsoft.Json.Serialization;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllers()
        .AddJsonOptions(options => {
            options.JsonSerializerOptions.PropertyNamingPolicy = null;
            options.JsonSerializerOptions.DictionaryKeyPolicy = null;
        })
        .AddNewtonsoftJson(options =>
        {
            options.SerializerSettings.ContractResolver = new DefaultContractResolver();
        })
        .AddOData(options => options.AddRouteComponents("api/odata", ODataConfig.GetEdmModel()).Expand().Filter().Count().OrderBy().Select().SetMaxTop(1000).SkipToken());

    // NLog
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Information);
    builder.Host.UseNLog();

    // Swagger
    builder.Services.AddSwaggerExamples();
    builder.Services.AddSwaggerGen(g => {
        g.EnableAnnotations();
        g.SwaggerDoc("v1", new() { Title = "POS BackOffice", Version = "v1" });

        g.ExampleFilters();
    });

    // Custom Validate Model
    builder.Services.Configure<ApiBehaviorOptions>(options =>
    {
        options.SuppressModelStateInvalidFilter = true;
    });

    // AppSettings
    var appSettingsConfig = builder.Configuration.GetSection("app_settings");
    var appSettings = appSettingsConfig.Get<APP_SETTINGS>();
    builder.Services.Configure<APP_SETTINGS>(appSettingsConfig);

    // Database
    var readWriteConn = builder.Configuration.GetConnectionString("ReadWriteMainDBContext");
    builder.Services.AddDbContext<ReadWriteMainDBContext>(options => options.UseSqlServer(readWriteConn));
    if (appSettings.IS_SEPARATE_READ_WRITE_DB)
    {   // Infrastructure(Server) must support data replica between 2 databases
        // Reccomend: Read replicas - Azure Database
        var readOnlyConn = builder.Configuration.GetConnectionString("ReadOnlyMainDBContext");
        builder.Services.AddDbContext<ReadOnlyMainDBContext>(options => options.UseSqlServer(readOnlyConn));
    }
    else
    {
        builder.Services.AddDbContext<ReadOnlyMainDBContext>(options => options.UseSqlServer(readWriteConn));
    }
    builder.Services.AddDatabaseDeveloperPageExceptionFilter();

    // Add others layer
    builder.Services.AddApplicationLayer();
    builder.Services.AddDomainLayer();
    builder.Services.AddCommonLayer();

    // JWT middleware
    // ..............................

    // App Build
    var app = builder.Build();

    // Execute DB Migrations Automatically on Startup (includes initial db creation)
    if (appSettings.IS_AUTO_MIGRATION_DB_ON_START_UP)
    {
        using (var scope = app.Services.CreateScope())
        {
            var readWrite = scope.ServiceProvider.GetRequiredService<ReadWriteMainDBContext>();
            readWrite.Database.Migrate();
            if (appSettings.IS_SEPARATE_READ_WRITE_DB)
            {
                var readOnly = scope.ServiceProvider.GetRequiredService<ReadOnlyMainDBContext>();
                readOnly.Database.Migrate();
            }
        }
    }

    //if (app.Environment.IsDevelopment())
    //{
        app.UseSwagger();
        app.UseSwaggerUI(ui =>
        {
            ui.RoutePrefix = $"api/document";
            ui.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
            ui.DefaultModelsExpandDepth(-1);
        });
    //}

    // Localization
    app.UseRequestLocalization(new RequestLocalizationOptions
    {
        DefaultRequestCulture = new RequestCulture(new CultureInfo(appSettings.DEFAULT_CULTURE_NAME)),
        SupportedCultures = appSettings.SUPPORT_CULTURES,
        SupportedUICultures = appSettings.SUPPORT_CULTURES,
    });

    // CORS: Production Need to specific origins "WithOrigins"
    app.UseCors(x => x.AllowAnyOrigin()
                      .AllowAnyMethod()
                      .AllowAnyHeader());

    //app.UseMiddleware<JwtMiddleware>();

    // For prod
    //app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    NLog.LogManager.Shutdown();
}

public class JsonLowercaseNamingPolicy : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        if (name == "recordsTotal" || name == "recordsFiltered")
        {
            return name;
        }
        else
        {
            return name.ToLowerInvariant();
        }
    }
}
