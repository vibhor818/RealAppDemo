using Microsoft.EntityFrameworkCore;
using RealAppDemo.DataContexts;
using RealAppDemo.DataInterfaces;
using RealAppDemo.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<VBContext>(options =>
{
    options.UseSqlServer(@"data source=(localdb)\mssqllocaldb;database=vbcustomerorderdb;trusted_connection=true");
});
builder.Services.AddTransient<IEmployeeRepository,EmployeeRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
