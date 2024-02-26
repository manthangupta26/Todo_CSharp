using System;
using System.Collections.Generic;

namespace TodoApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> TodoList = new List<string>();
            
            while (true)
            {
                Console.WriteLine("1: Enter TODO");
                Console.WriteLine("2: Exit");

                int choice = int.Parse(Console.ReadLine());

                if(!(choice == 1 || choice == 2))
                {
                    Console.WriteLine("Please Enter only the 2 Values that were Given : 1 - For Enter Todo, 2 - Exit Todo");
                }

                else if(choice == 1) 
                {
                    Console.WriteLine("Enter the Task that you want to Add");
                    string Task = Console.ReadLine();
                    TodoList.Add(Task);
                    Console.Clear();
                    Console.WriteLine("Task Added Successfully");
                }

                else if(choice == 2)
                {
                    Console.WriteLine("Thank You for Stopping By");
                    break;
                }
            }

            Console.WriteLine("TODO List :");
            if( TodoList.Count > 0)
            {
                for (int i = 0; i < TodoList.Count; i++)
                {
                    Console.WriteLine("- " + TodoList[i]);
                }
            }
            else
            {
                Console.WriteLine("No Todos to Display");
            }


        }
    }

    public enum UserChoice
    {
        AddTask = 1 ,
        Exit 
    }
}
