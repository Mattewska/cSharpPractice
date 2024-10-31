namespace presupuesto
{
    internal class Program
    {
        public static List<string> tareasActivas = new List<string>();
        
        public static void Main(string[] args)
        {
            int ConversorTareaElegida = 0;
            
            do
            {
                Console.WriteLine("Elija una Opcion para Continuar \n 1:Listar\n 2:Agregar\n 3:Eliminar\n 4:Salir");
                string TareaElegida = Console.ReadLine();
                if (int.TryParse(TareaElegida, out ConversorTareaElegida))
                {
        
                    if ((Opciones)ConversorTareaElegida == Opciones.Listar)
                    {
                        Console.WriteLine("Listando...");
                    }else if ((Opciones)ConversorTareaElegida == Opciones.Nuevo)
                    {
                        Console.WriteLine("Agregando...");
                        AgregarTarea();
                    }else if ((Opciones)ConversorTareaElegida == Opciones.Eliminar)
                    {
                        Console.WriteLine("Eliminando...");
                    }else if ((Opciones)ConversorTareaElegida == Opciones.Salir)
                    {
            
                        Console.WriteLine("Adios!");
                    }
                }
                else
                {
                    ConversorTareaElegida = 0;
                    Console.WriteLine("La tarea Elegida es invalida.");
                }
            } while ((Opciones)ConversorTareaElegida == Opciones.Salir);
        }
        
        public static void AgregarTarea()
        {
            string NuevaTarea = Console.ReadLine();
            tareasActivas.Add(NuevaTarea);
        }
        
        public void ListarTareas()
        {
            foreach (var var in tareasActivas)
            {
                Console.WriteLine(var);
            }
        }
        
        public enum Opciones
        {
            Listar = 1,
            Nuevo = 2,
            Eliminar = 3,
            Salir = 4
        }
        
        
    }
}









