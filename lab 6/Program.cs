using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace lab_6
{
    class RecentTasks
    {
        static void Main(string[] args)
        {
            // Create a program that simulates a simple “Recent Tasks” tracker using a 
            // Stack<string>.Each time the user performs a task, push it onto the stack.
            // The program should display the most recent task(top of the stack) and
            // allow “undo” by popping an item. 

            //Stack<string> tasks = new Stack<string>();
            //int choice;

            //do
            //{
            //    Console.WriteLine("\n--- Recent Tasks Tracker ---");
            //    Console.WriteLine("1. Add Task");
            //    Console.WriteLine("2. View Most Recent Task");
            //    Console.WriteLine("3. Undo Last Task");
            //    Console.WriteLine("4. Exit");
            //    Console.Write("Enter your choice: ");
            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter task name: ");
            //            string task = Console.ReadLine();
            //            tasks.Push(task);
            //            Console.WriteLine("Task added successfully.");
            //            break;

            //        case 2:
            //            if (tasks.Count > 0)
            //                Console.WriteLine("Most Recent Task: " + tasks.Peek());
            //            else
            //                Console.WriteLine("No tasks available.");
            //            break;

            //        case 3:
            //            if (tasks.Count > 0)
            //                Console.WriteLine("Undo Task: " + tasks.Pop());
            //            else
            //                Console.WriteLine("No tasks to undo.");
            //            break;

            //        case 4:
            //            Console.WriteLine("Exiting program...");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice!");
            //            break;
            //    }

            //} while (choice != 4);

            //Write a C# program to count the number of vowels and consonants in a 
            //given string.Ignore spaces and handle both uppercase and lowercase
            //characters.

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //int vowels = 0, consonants = 0;

            //foreach (char ch in input)
            //{
            //    if (char.IsLetter(ch))
            //    {
            //        char c = char.ToLower(ch);

            //        if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            //        {
            //            vowels++;
            //        }
            //        else
            //        {
            //            consonants++;
            //        }
            //    }
            //}
            //Console.WriteLine("Number of vowels: " + vowels);
            //Console.WriteLine("Number of consonants: " + consonants);

            //Simulate a customer service queue using a Queue< string >.Customers arrive
            //in sequence and are served in the order they arrived(FIFO). The program
            //should allow adding customers, serving one, and displaying who’s next. 

            //Queue<string> customers = new Queue<string>();
            //int choice;

            //do
            //{
            //    Console.WriteLine("\n--- Customer Service Queue ---");
            //    Console.WriteLine("1. Add Customer");
            //    Console.WriteLine("2. Serve Customer");
            //    Console.WriteLine("3. Show Next Customer");
            //    Console.WriteLine("4. View All Customers");
            //    Console.WriteLine("5. Exit");
            //    Console.Write("Enter your choice: ");

            //    choice = int.Parse(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter customer name: ");
            //            string name = Console.ReadLine();
            //            customers.Enqueue(name);
            //            Console.WriteLine($"{name} added to the queue.");
            //            break;

            //        case 2:
            //            if (customers.Count > 0)
            //            {
            //                string servedCustomer = customers.Dequeue();
            //                Console.WriteLine($"{servedCustomer} has been served.");
            //            }
            //            else
            //            {
            //                Console.WriteLine("No customers in the queue.");
            //            }
            //            break;

            //        case 3:
            //            if (customers.Count > 0)
            //            {
            //                Console.WriteLine($"Next customer: {customers.Peek()}");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Queue is empty.");
            //            }
            //            break;

            //        case 4:
            //            if (customers.Count > 0)
            //            {
            //                Console.WriteLine("Customers in queue:");
            //                foreach (string customer in customers)
            //                {
            //                    Console.WriteLine(customer);
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Queue is empty.");
            //            }
            //            break;

            //        case 5:
            //            Console.WriteLine("Exiting program...");
            //            break;

            //        default:
            //            Console.WriteLine("Invalid choice! Try again.");
            //            break;
            //    }

            //} while (choice != 5);

//Write a C# program to check whether a given string is a palindrome (reads 
//the same backward and forward). Ignore case and spaces. 

            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string cleaned = input.Replace(" ", "").ToLower();

            //bool isPalindrome = true;
            //int length = cleaned.Length;

            //for (int i = 0; i < length / 2; i++)
            //{
            //    if (cleaned[i] != cleaned[length - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //if (isPalindrome)
            //    Console.WriteLine("The string is a palindrome.");
            //else
            //    Console.WriteLine("The string is NOT a palindrome.");
        }
    }
}