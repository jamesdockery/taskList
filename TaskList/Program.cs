using System;
using System.Collections.Generic;

namespace TaskList
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();


            while (true)
            {
                Console.Clear();
                TaskApp app = new TaskApp();

                int input = Convert.ToInt32(Console.ReadLine());

                if (input == 1)
                {
                    app.ListTasks();

                }
                else if (input == 2)
                {
                    app.AddTasks();

                }else if(input == 3)
                {
                    app.DeleteTasks();
                }

            }






        }
    }
}
