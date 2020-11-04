/*
Write a C# Sharp program to check two given integers whether either of them is in the range 100..200 inclusive
*/
using System;

namespace Exercice_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumberOne = 0,
                userNumberTwo = 0;
            string userInput = String.Empty;

            Console.WriteLine("Check two given integers whether either of them is in the range 100..200 inclusive");

            Console.Write("Enter yours integers (coma separated): ");
            userInput = Console.ReadLine();
            userNumberOne = Convert.ToInt32(userInput.Split(",")[0]);
            userNumberTwo = Convert.ToInt32(userInput.Split(",")[1]);

            Console.WriteLine((userNumberOne >= 100 && userNumberOne <= 200) || (userNumberTwo >= 100 && userNumberTwo <= 200) ? "true" : "false");
        }
    }
}
