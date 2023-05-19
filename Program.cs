using Microsoft.EntityFrameworkCore;
using TaskMenager.Models;
using TaskMenager.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
//Nie wiem jak polaczyc
builder.Services.AddDbContext<TaskManagerContext>(options => options.UseSqlServer("Server=DESKTOP-18IL65C\\SQLEXPRESS;Database=TaskManagerDB;Trusted_Connection=True;"));
builder.Services.AddTransient<ITaskRepository, TaskRepository>();

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
    pattern: "{controller=Task}/{action=Index}/{id?}");

app.Run();
