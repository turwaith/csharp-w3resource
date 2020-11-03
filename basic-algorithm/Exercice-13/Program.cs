/*
Write a C# Sharp program to check if one given temperatures is less than 0 and the other is greater than 100. 
*/
using System;

namespace Exercice_13
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int tempOne = 0,
                tempTwo = 0;

            Console.WriteLine("Check if one given temperatures is less than 0 and the other is greater than 100");

            Console.Write("Enter yours temperatures (coma separeted) ");
            userInput = Console.ReadLine();
            tempOne = Convert.ToInt32(userInput.Split(",")[0]);
            tempTwo = Convert.ToInt32(userInput.Split(",")[1]);

            Console.WriteLine((tempOne > 100 && tempTwo < 0) || (tempOne < 0 && tempTwo > 100) ? "true" : "false");
        }
    }
}
