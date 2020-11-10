/*
Write a C# Sharp program to create a new string which is n (non-negative integer) copies of a given string
*/
using System;

namespace Exercice_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userString = String.Empty,
                   userOutput = String.Empty;
            int userNumber = 0;

            Console.WriteLine("Create a new string which is n (non-negative integer) copies of a given string");

            Console.Write("Enter your string and the number (positive) of repetition (coma separeted): ");
            userInput = Console.ReadLine();
            userString = userInput.Split(",")[0];
            userNumber = Convert.ToInt32(userInput.Split(",")[1]);

            for(int i = 0; i < userNumber; i++) userOutput += userString;

            Console.WriteLine(userOutput);
        }
    }
}
