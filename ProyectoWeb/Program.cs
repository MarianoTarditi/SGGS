using DAL.Enumerators;
using DAL.Context;
using NToastNotify;
using ServiceLayer.Extensions;
using NLog.Web;
using ServiceLayer.Middlewares.Identity;
using Microsoft.EntityFrameworkCore;
using Entity.Identity.ViewModels;
using FluentValidation;
using ServiceLayer.FluentValidation.Identity;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.Drawing;
using Entity.Identity.Entities;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddNToastNotifyToastr(new ToastrOptions
{
    ProgressBar = true,
    PositionClass = ToastPositions.BottomCenter,
    TimeOut = 5000,

});

builder.Services.AddDbContext<dbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.LoadRepositoryLayerExtensions(builder.Configuration);
builder.Services.LoadServiceLayerExtensions(builder.Configuration);

// NLog: Setup NLog for Dependency injection
builder.Logging.ClearProviders();
builder.Host.UseNLog();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{


    app.UseHsts();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.

}

app.MapGet("/", async (HttpContext context, UserManager<AppUser> userManager) =>
{
    // Verifica si el usuario está autenticado
    if (context.User.Identity?.IsAuthenticated ?? false)
    {
        // Obtiene el usuario autenticado
        var user = await userManager.GetUserAsync(context.User);

        if (user != null)
        {
            // Obtiene los roles del usuario
            var roles = await userManager.GetRolesAsync(user);

            // Si es un "External Member", lo redirige a la página de espera
            if (roles.Contains("External Member"))
            {
                return Results.Redirect("/EsperarAprobacion");
            }
        }
    }

    // Redirige al Dashboard por defecto si no es External Member
    return Results.Redirect("/Dashboard");
});



//app.MapGet("/", () => Results.Redirect("/Dashboard"));
//app.UseExceptionHandler("/Error/GeneralExceptions");
//app.UseStatusCodePagesWithRedirects("/Error/PageNotFound");
//app.UseStatusCodePagesWithReExecute("/Error/PageNotFound");
app.UseNToastNotify();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapControllers();


app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<SecurityStampCheck>();


#pragma warning disable ASP0014
//app.UseEndpoints(endpoint =>
//{
//    endpoint.MapAreaControllerRoute(
//        name: "Admin",
//        areaName: "Admin",
//        pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}");

//    endpoint.MapAreaControllerRoute(
//        name: "User",
//        areaName: "User",
//        pattern: "User/{controller=Dashboard}/{action=Index}/{id?}");

//    endpoint.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
