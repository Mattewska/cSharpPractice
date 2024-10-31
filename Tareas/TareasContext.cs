using Microsoft.EntityFrameworkCore;
using Tareas.Models;

namespace Tareas;

public class TareasContext : DbContext
{
    public DbSet<Tarea> Tareas { get; set; }
    
    public TareasContext(DbContextOptions<TareasContext> options) : base(options){}
}