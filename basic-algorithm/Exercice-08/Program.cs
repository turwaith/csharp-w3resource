/*
Write a C# Sharp program to create a new string which is 4 copies of the 2 front characters of a given string.
If the given string length is less than 2 return the original string
*/
using System;

namespace Exercice_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Create a new string which is 4 copies of the 2 front characters of a given string." +
                             "If the given string length is less than 2 return the original string");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            if(userInput.Length < 2) Console.WriteLine(userInput);
            else Console.WriteLine("Output           : " + userInput[0..2]+userInput[0..2]+userInput[0..2]+userInput[0..2]);
        }
    }
}
