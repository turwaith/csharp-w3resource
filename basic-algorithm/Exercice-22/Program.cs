/*
Write a C# Sharp program to check if a given string contains between 2 and 4 'z' character.
*/
using System;

namespace Exercice_22
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int count = 0;

            Console.WriteLine("Check if a given string contains between 2 and 4 'z' character");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            foreach(char item in userInput)
            {
                if(item == 'z') count++;
            }

            Console.WriteLine(2 <= count && count <= 4 ? "true" : "false");
        }
    }
}
