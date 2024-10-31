using System;
using System.Collections.Generic;

namespace ToDo
{
    internal class Program
    {
        public static List<string> TaskList { get; set; }

        static void Main(string[] args)
        {
            TaskList = new List<string>();
            int chooseMenuAction;
            do
            {
                chooseMenuAction = ShowMainMenu();
                if ((Menu)chooseMenuAction == Menu.Add)
                {
                    ShowMenuAddTask();
                }
                else if ((Menu)chooseMenuAction == Menu.Remove)
                {
                    ShowMenuRemoveTask();
                }
                else if ((Menu)chooseMenuAction == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)chooseMenuAction != Menu.Exit);
        }
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");
            
            int MenuNumberOfmerbers = Menu.GetValues(typeof(Menu)).Length;
            // Read line
            string chooseAction = Console.ReadLine();
            // chooseAction Filter
            int chooseActionFiltred;
            if (int.TryParse(chooseAction, out chooseActionFiltred))
            {
                if (chooseActionFiltred > MenuNumberOfmerbers || chooseActionFiltred < 1)
                {
                    Console.WriteLine("La accion seleccionada no existe.");
                }
            }
            else
            {
                Console.WriteLine("El programa solo recibe numeros.");
                chooseActionFiltred = 0;
            }
            
            return chooseActionFiltred;
            
        }

        public static void ShowTaskList()
        {
            int IndexTask = 0;
            
            Console.WriteLine("----------------------------------------");
            TaskList.ForEach(p => Console.WriteLine(++IndexTask + ". " + p));
            Console.WriteLine("----------------------------------------");
        }

        public static void ShowMenuRemoveTask()
        {
            try
            {
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                ShowTaskList();

                string chooseTaskToRemove = Console.ReadLine();
                // Remove one position
                int taskToRemove = Convert.ToInt32(chooseTaskToRemove) - 1;
                if (taskToRemove < 0 || taskToRemove > TaskList.Count)
                {
                    Console.WriteLine("La tarea seleccionada no existe.");
                }
                else
                {
                    if (taskToRemove > -1 && TaskList.Count > 0)
                    {
                        string showRemovedTask = TaskList[taskToRemove]; 
                        TaskList.RemoveAt(taskToRemove);
                        Console.WriteLine("Tarea " + showRemovedTask + " eliminada");
                    }
                }
                
                
            }
            catch (Exception)
            {
                Console.WriteLine("ha ocurrido un error");
            }
        }

        public static void ShowMenuAddTask()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string chooseTaskName = Console.ReadLine();
                TaskList.Add(chooseTaskName);
                Console.WriteLine("Tarea registrada");
            }
            catch (Exception)
            {
                Console.WriteLine("ha ocurrido un error");
            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList == null || TaskList.Count == 0)
            {
                Console.WriteLine("No hay tareas por realizar");
            } 
            else
            {
                ShowTaskList();
            }
        }
    }

    public enum Menu
    {
        Add = 1,
        Remove = 2,
        List = 3,
        Exit = 4
    }
}
