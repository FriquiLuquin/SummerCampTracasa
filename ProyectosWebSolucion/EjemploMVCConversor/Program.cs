using EjemploMVCConversor.Servicios;
using EjemploMVCConversor.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//++ 1-Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ContextoConversor>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
});


builder.Services.AddScoped<IServicioMonedas, ServicioCriptoMonedas>();
builder.Services.AddScoped<IRepositorioMonedas, RepositorioMonedasMemoria>();

var app = builder.Build();

//++ 2-Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
else
{

}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
