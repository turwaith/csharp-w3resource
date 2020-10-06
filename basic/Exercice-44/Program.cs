/*
 Write a C# program to create a new string of every other character (odd position) from the first position of a given string.
    Test Data:
    Input a string : w3resource
    Sample Output
    wrsuc
*/
using System;

namespace Exercice_44
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userOutput = String.Empty;

            Console.WriteLine("create a new string of every other character (odd position) from the first position of a given string.");
            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            for(int i = 0, size = userInput.Length - 1; i < size; i+=2)
            {
                userOutput += userInput[i];
            }

            Console.WriteLine(userOutput);
        }
    }
}
