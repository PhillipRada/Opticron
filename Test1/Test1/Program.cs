using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Test1.DBContext;

var builder = WebApplication.CreateBuilder(args);

// Add services for Razor Pages
builder.Services.AddRazorPages();

// Get the configuration from the builder
var configuration = builder.Configuration;

// Add DbContext to the services BEFORE building the app
builder.Services.AddDbContext<CardProductsDBContext>(options =>
{
    options.UseSqlServer(configuration.GetConnectionString("OptiDatabaseConnectionString"));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
