/*
Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.
*/
using System;

namespace Exercice_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   outPut = String.Empty;            

            Console.WriteLine("Exchange the first and last characters in a given string and return the new string");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            if(userInput.Length == 1) outPut = userInput;
            else
            {
                outPut = userInput[^1].ToString();
                outPut += userInput[1..^1];
                outPut += userInput[0].ToString();            
            }

            Console.WriteLine($"The string with first and last characters exchanged: {outPut}");

        }
    }
}
