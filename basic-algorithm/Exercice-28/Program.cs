/*
Write a C# Sharp program to check if the first appearance of "a" in a given string is immediately followed by another "a"
*/
using System;

namespace Exercice_28
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            int position = 0;

            Console.WriteLine("Check if the first appearance of \"a\" in a given string is immediately followed by another \"a\"");
        
            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            position = userInput.IndexOf("a");
            
            Console.WriteLine(position >= 0 && userInput[position + 1] == 'a' ? "true" : "false");
        }
    }
}
