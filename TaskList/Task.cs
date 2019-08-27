using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskList
{
    public class Task
    {
        string MemberName { get; set; }
        string TaskDescription { get; set; }
        String DueDate { get; set; }

       string Completed { get; set; }

        public void MarkComplete()
        {
            this.Completed = "Yes";
        }

        public Task()
        { 
            Console.WriteLine("Member Name: ");
          string  name = Console.ReadLine();
            this.MemberName = name;

            Console.WriteLine("Task Description: ");
           string description = Console.ReadLine();
            this.TaskDescription = description;

            Console.WriteLine("Due Date: ");
           string duedate = Console.ReadLine();
            this.DueDate = duedate;

            Console.WriteLine("Completed: ");
            string completed =Console.ReadLine();
            this.Completed = completed;
        }
        public override string ToString()
        {
            return " Name: " + MemberName + " Description: " + TaskDescription + " Due Date: " + DueDate + " Completed " + Completed;
        }

    }
}
