using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Project_Management.Data;
using Project_Management.Repositories;   // ✅ ADD THIS

var builder = WebApplication.CreateBuilder(args);

// ------------------ DATABASE ------------------
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// ------------------ IDENTITY ------------------
builder.Services.AddDefaultIdentity<IdentityUser>(options =>
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

// ------------------ MVC ------------------
builder.Services.AddControllersWithViews();

// ------------------ REPOSITORY (IMPORTANT) ------------------
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();   // ✅ ADD THIS

var app = builder.Build();

// ------------------ PIPELINE ------------------
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();          // ✅ ADD THIS

app.UseRouting();

app.UseAuthentication();       // ✅ ADD THIS (VERY IMPORTANT)
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();