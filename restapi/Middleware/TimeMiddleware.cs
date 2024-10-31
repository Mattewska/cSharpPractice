namespace restapi.Middleware;

public class TimeMiddleware
{
    readonly RequestDelegate _next;
    //Constructor
    public TimeMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    //Metodo por defecto en todos los middlewares
    public async Task InvokeAsync(HttpContext context)
    {
        //_next(context) invoca al middleware que sigue; hace que este siempre se ejecute despues del resto.
        await _next(context); 
        if (context.Request.Query.Any(p => p.Key == "time"))
        {
            await context.Response.WriteAsync(DateTime.Now.ToShortTimeString()); 
        }
    }
}

//Clase que permite usar el Middleware en la clase Program.
public static class TimeMiddlewareExtensions
{
    public static IApplicationBuilder UseTimeMiddleware(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<TimeMiddleware>();
    }
}