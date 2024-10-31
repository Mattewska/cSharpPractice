using System.ComponentModel.DataAnnotations;

namespace Tareas.Models;

public class Tarea
{
    [Key]
    public int IdTarea { get; set; }
    public string NombreTarea { get; set; }
    public string DescripcionTarea { get; set; }
}