using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LoanSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using LoanSystem.Application.Interfaces;
using LoanSystem.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddRazorPages();

// Configure EF Core to use SQL Server LocalDB (DefaultConnection from appsettings.json)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? "Server=.;Database=LoanSystemDb;User Id=sa;Password=123456;MultipleActiveResultSets=true;TrustServerCertificate=True"));
// Register generic repository
builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));

// AutoMapper registration (Application mapping profile)
builder.Services.AddAutoMapper(typeof(LoanSystem.Application.Mappings.DomainProfile).Assembly);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
