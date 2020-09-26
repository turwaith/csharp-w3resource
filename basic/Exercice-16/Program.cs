/*
Write a C# program to create a new string from a given string where the first and last characters will change their positions.
Test Data:
    w3resource
    Python
Sample Output:
    e3resourcw
    nythoP
*/
using System;

namespace Exercice_16
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty,
                   userWord = String.Empty;
            
            Console.Write("Enter a string: ");
            userInput = Console.ReadLine();
            userWord += userInput[userInput.Length - 1];            
            userWord += userInput.Substring(1,userInput.Length -2);
            userWord += userInput[0];            
       
            Console.WriteLine($"Before: {userInput}");     
            Console.WriteLine($"After : {userWord}");
        }
    }
}
