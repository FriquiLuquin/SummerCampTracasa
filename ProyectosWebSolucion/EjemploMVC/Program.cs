using EjemploMVC.Data;
using EjemploMVC.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

// 1-Crear interfaz IMail
// 2-Crear dos clases MailDesarrollo y MailProduccion
// 3-Configurar el servicio 
// 4-Agregar interfaz en el constructor
// 5-Enviar un correo en el momento que va a la pagina Privacy

var builder = WebApplication.CreateBuilder(args); // IMPORTANTE

//++ 1. Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews(); // MVC

//+ Cuando se instancie IMail sera el que se especifique aqui
builder.Services.AddScoped<IMail, MailDesarrollo>();

var app = builder.Build(); // IMPORTANTE

//++ 2. Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run(); // IMPORTANTE
