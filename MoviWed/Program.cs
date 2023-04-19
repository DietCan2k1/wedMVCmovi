using Microsoft.EntityFrameworkCore;
using MoviWed.Common;
using MoviWed.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


// Connection Database
var apiOption = builder.Configuration.GetSection("ApiOption").Get<ApiOption>();
builder.Services.AddSingleton<ApiOption>(apiOption);


builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseMySql(apiOption.StringConnection,
    MySqlServerVersion.LatestSupportedServerVersion)
);
var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
