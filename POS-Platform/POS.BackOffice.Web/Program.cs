using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using POS.BackOffice.Web;
using POS.BackOffice.Web.Configuration;
using POS.BackOffice.Web.Data;
using POS.Common;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// AppSettings
var appSettingsConfig = builder.Configuration.GetSection("app_settings");
builder.Services.Configure<APP_SETTINGS>(appSettingsConfig);

// Dependency Injection
builder.Services.AddServices();
builder.Services.AddCommonLayer();

// Syncfusion
#pragma warning disable CS0618 // 'GlobalOptions.IgnoreScriptIsolation' is obsolete: 'Obsolete. Refer scripts externally instead of loading scripts via Javascript isolation by setting this property value as false.'
builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
#pragma warning restore CS0618 // 'GlobalOptions.IgnoreScriptIsolation' is obsolete: 'Obsolete. Refer scripts externally instead of loading scripts via Javascript isolation by setting this property value as false.'

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
