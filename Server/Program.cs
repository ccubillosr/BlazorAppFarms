using Microsoft.AspNetCore.ResponseCompression;
using BlazorAppFarms.Shared.Data;
using BlazorAppFarms.Shared.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using BlazorAppFarms.Server.Data;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BlazorAppFarmsServerContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("Animals") ?? throw new InvalidOperationException("Connection string 'BlazorAppFarmsServerContext' not found.")));
builder.Services.AddHttpClient();
builder.Services.AddDbContext<AnimalStoreContext>(
    options => options.UseSqlite(builder.Configuration.GetConnectionString("Animals") ?? throw new InvalidOperationException("Connection string 'BlazorAppFarmsServerContext' not found.")));
//builder.Services.AddSqlite<AnimalStoreContext>("Data Source=Animals.db");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
// Initialize the database
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<BlazorAppFarmsServerContext>();
    var boolean = false;
    if (db.Database.EnsureCreated())
    {
        SeedData.Initialize(db);
        boolean = true;
    }
    if (boolean == false)
    {
        SeedData.Remover(db);
        SeedData.Initialize(db);
    }
}
var scopeFactoryS = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scopeS = scopeFactoryS.CreateScope())
{
    var dbs = scopeS.ServiceProvider.GetRequiredService<AnimalStoreContext>();
}

app.UseHttpsRedirection();


app.UseStaticFiles();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.MapRazorPages();
app.MapControllerRoute("Animal", "{controller=Animals}/{action=Index}/{id?}");
app.Run();
