using restapi.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
IServiceCollection services = builder.Services;

services.AddAuthorization();
services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
//Middlewares
app.UseHttpsRedirection();

app.UseAuthorization();

//app.UseWelcomePage();
app.UseTimeMiddleware();
    
app.MapControllers();

app.Run();