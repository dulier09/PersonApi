using Microsoft.EntityFrameworkCore;
using WebApiPerson.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Crear variable para la cadena de Conexi�n
var connectionString = builder.Configuration.GetConnectionString("Connection");
// Registrar Servicio para la Conexi�n
builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(connectionString)
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();