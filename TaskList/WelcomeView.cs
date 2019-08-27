using System;
namespace TaskList
{
    public class WelcomeView
    {
        public WelcomeView()
        {
            Console.WriteLine("Welcome to your new task list. Please choose from the following.");
            string[] list = new string[] { "1. List Tasks", "2. Add Tasks", "3. Delete Task", "4. Mark Task Complete",
                "5. Quit"
            };

            string str = string.Join("\n", list);

            Console.WriteLine(str);
        }

    }
}
