using System;
using System.Collections.Generic;

namespace TaskList
{
    public class TaskApp
    {
       
        List<Task> tasks = new List<Task>();
        public TaskApp()
        {
            Console.WriteLine("Welcome to your new task list. Please choose from the following.");
            string[] list = new string[] { "1. List Tasks", "2. Add Tasks", "3. Delete Task", "4. Mark Task Complete",
                "5. Quit"
            };

            string str = string.Join("\n", list);

            Console.WriteLine(str);
         

        }

        public void ListTasks()
        {
            int i = 0;
            foreach (Task t in tasks)
            {
                Console.WriteLine(i++ + t.ToString());
            }
        }
        public void AddTasks()
        {
            Task t1 = new Task();
            tasks.Add(t1);
            Console.Clear();
        }
        public void DeleteTasks()
        {
            Console.WriteLine("Which task would you like to delete?");
            int num = Convert.ToInt32(Console.ReadLine());
            tasks.RemoveAt(num);
            Console.WriteLine("Task at" + num + "deleted!");
        }
        public void MarkComplete()
        {
            Console.WriteLine("Which task would you like to mark complete? Enter 0-"+ (tasks.Count - 1));
            int input = Convert.ToInt32(Console.ReadLine());
            Task c = tasks[input];
            c.MarkComplete();
            Console.Clear();
            Console.WriteLine("Task is marked completed!");
            


        }
    }
}
