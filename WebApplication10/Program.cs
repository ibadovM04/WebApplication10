using Microsoft.EntityFrameworkCore;
using WebApplication10.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Database:Connection"]);
});

builder.Services.AddControllersWithViews();
var app = builder.Build();
app.MapControllerRoute("default", "{controller=Home}/{action=Index}");
app.UseStaticFiles();

app.Run();
