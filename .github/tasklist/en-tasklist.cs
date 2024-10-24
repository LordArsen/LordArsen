using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace TodoList
{
    class Program
    {
        static List<string> tasks = new List<string>();
        static List<bool> completedTasks = new List<bool>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        ListTasks();
                        break;

                    case "3":
                        CompleteTask();
                        break;

                    case "4":
                        DeleteTask();
                        break;

                    case "5":
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid selection! Press any key to continue.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void ShowMenu()
        {
            Console.WriteLine("== Personal Task List ==");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. List Tasks");
            Console.WriteLine("3. Complete Task");
            Console.WriteLine("4. Delete Task");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
        }

        static void AddTask()
        {
            Console.Write("New task: ");
            string newTask = Console.ReadLine();
            tasks.Add(newTask);  
            completedTasks.Add(false);  
        }

        static void ListTasks()
        {
            Console.WriteLine("=== Task List ===");
            for (int i = 0; i < tasks.Count; i++)
            {
                string status = completedTasks[i] ? "[Completed]" : "[Pending]";
                Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void CompleteTask()
        {
            Console.Write("Enter the number of the completed task: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number <= tasks.Count && number > 0)
            {
                completedTasks[number - 1] = true;
                Console.WriteLine("Task completed! Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Invalid task number! Press any key to continue...");
            }
            Console.ReadKey();
        }

        static void DeleteTask()
        {
            Console.Write("Enter the number of the task to delete: ");
            if (int.TryParse(Console.ReadLine(), out int number) && number <= tasks.Count && number > 0)
            {
                tasks.RemoveAt(number - 1);
                completedTasks.RemoveAt(number - 1);
                Console.WriteLine("Task deleted! Press any key to continue...");
            }
            else
            {
                Console.WriteLine("Invalid task number! Press any key to continue...");
            }
            Console.ReadKey();
        }
    }
}
