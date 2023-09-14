using Microsoft.EntityFrameworkCore;
using Perfiles;
using Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IRepositorioBD,RepositorioBD>();

builder.Services.AddCors(options =>
             {
                 options.AddPolicy("AllowAll",
                     builder =>
                     {
                         builder
                         .AllowAnyOrigin()
                         .AllowAnyMethod()
                         .AllowAnyHeader();
                     });
             });


builder.Services.AddDbContext<ContextoExamen.ContextoExamen>(options =>
          {
              options.UseSqlServer(builder.Configuration["ConnectionStrings:ConexionDatos"]);
          });

builder.Services.AddAutoMapper(typeof(PersonaProfile) );
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
  app.UseCors("AllowAll");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
