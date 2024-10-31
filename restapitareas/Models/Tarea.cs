namespace restapitareas.Models;

public class Tarea
{
    public uint IdTarea { get; set; }
    public uint IdCategoria { get; set; }
    public string TituloTarea { get; set; }
    public string DescripcionTarea { get; set; }
    
    public virtual Categoria Categoria { get; set; }
}