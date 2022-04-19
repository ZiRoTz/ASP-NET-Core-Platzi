using ASP_NET_y_GIT.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EscuelaContext>(options => options.UseInMemoryDatabase("testDB"));


var app = builder.Build();

using(var scope=app.Services.CreateScope()){
    var serv=scope.ServiceProvider;
    try
    {
        var contex=serv.GetRequiredService<EscuelaContext>();
        contex.Database.EnsureCreated();
    }
    catch (Exception ex)
    {
        var logger = serv.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error ocurred creating the DB.");
    }

}

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
    pattern: "{controller=Escuela}/{action=Index}/{id?}");

app.Run();