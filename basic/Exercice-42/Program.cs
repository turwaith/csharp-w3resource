/*
Write a C# program to create a new string where the first 4 characters will be in lower case.
If the string is less than 4 characters then make the whole string in upper case.
    Test Data:
    Input a string: w3r
    Sample Output
    W3R
*/
using System;

namespace Exercice_42
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userOutput = String.Empty; 

            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            if(userInput.Length < 4) userOutput = userInput.ToUpper();
            else
            {
                userOutput += userInput[0..4].ToLower();
                userOutput += userInput[4..];
            }

            Console.WriteLine(userOutput);
        }
    }
}
