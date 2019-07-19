using System;

namespace Decisions 
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Billy's Big Givaway");
            Console.Write("Choose a door: 1, 2 or 3: ");
            string userValue = Console.ReadLine();

            string message = "";

            if(userValue == "1")
            {
              message = "You won a new car!";
            }
            else if (userValue == "2")
            {
              message = "You won a new boat!";
            }
            else if (userValue == "3")
            {
              message = "You won a new cat!";
            }
            else
            {
                message = "I'm sorry we didn't understand that. ";
                message += "You lose.";
            }
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}