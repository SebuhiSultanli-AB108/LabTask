using Microsoft.EntityFrameworkCore;
using Pronia.BL.Services.Abstraction;
using Pronia.BL.Services.Concretes;
using Pronia.DAL.Contexts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
string? connStr = builder.Configuration.GetConnectionString("MSSql");
builder.Services.AddDbContext<ProniaDbContext>(opt => opt.UseSqlServer(connStr));
builder.Services.AddScoped<ISliderItemService, SliderItemService>();

var app = builder.Build();
app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
app.UseStaticFiles();
app.Run();
