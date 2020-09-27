/*
Write a C# program to convert a given string into lowercase.
Sample Output:
    write a c# sharp program to display the following pattern using the alphabet
*/
using System;

namespace Exercice_23
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Enter a string to put into lowercase: ");
            userInput = Console.ReadLine();
            
            Console.WriteLine($"{userInput.ToLower()}");
        }
    }
}
