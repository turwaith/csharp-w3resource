/*
Write a C# Sharp program to count the string "aa" in a given string and assume "aaa" contains two "aa"
*/
using System;

namespace Exercice_27
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int count = 0;

            Console.WriteLine("Count the string \"aa\" in a given string and assume \"aaa\" contains two \"aa\"");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            for(int i = 0; i < userInput.Length; i++)
            {
                if(userInput[i] == 'a' && i != (userInput.Length - 1) && userInput[i+1] == 'a') count++;
            }

            Console.WriteLine($"Total of \"aa\" in {userInput}: {count}");
        }
    }
}
