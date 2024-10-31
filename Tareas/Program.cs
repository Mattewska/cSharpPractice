using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tareas;

var builder = WebApplication.CreateBuilder(args);
//Conexion a la base de datos.
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasMateo"));
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("DbTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/DbContext", async ([FromServices] TareasContext context) =>
{
    context.Database.EnsureCreated();
    return Results.Ok($"La conexion en memoria es: {context.Database.IsInMemory()}");
});

app.Run();
