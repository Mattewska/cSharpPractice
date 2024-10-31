namespace restapitareas.Models;

public class Categoria
{
    public uint IdCategoria { get; set; }
    public string NombreCategoria { get; set; }
    public string Descripcion { get; set; }
    
    public ICollection<Tarea> Tareas { get; set; }
}