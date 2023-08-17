using Biblioteca;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//+ 1-Add services to the container

builder.Services.AddControllers(); // MVC

// Documentador de la API
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Inyeccion de dependencias
builder.Services.AddScoped<IRepositorioMonedas, RepositorioMonedas>();


builder.Services.AddDbContext<ContextoConversor>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
});

var app = builder.Build();

//+ 2-Configure the HTTP request pipeline

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();   // Prepara la documentacion
    app.UseSwaggerUI(); // Genera la documentacion
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.MapGet("/", () => "Hello World!");

app.Run();
