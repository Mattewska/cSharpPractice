using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using proyectef;

var builder = WebApplication.CreateBuilder(args);


//Prueba de connexion a la base de datos en memoria
//builder.Services.AddDbContext<TareasContext>(p => p.UseInMemoryDatabase("TareasDb"));
//Conexion a la base de datos real
builder.Services.AddSqlServer<TareasContext>(builder.Configuration.GetConnectionString("dbTareas"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// Test de conexion a la base de datos
app.MapGet("/dbConection", async ([FromServices] TareasContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("Base de datos en memoria:" + dbContext.Database.IsInMemory());
});



app.Run();
