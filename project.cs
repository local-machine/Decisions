using System;

namespace Variables 
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            Console.Write("Enter your first name: ");
            string userFirstName = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string userLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + userFirstName + " " + userLastName);
            Console.ReadLine();
        }
    }
}