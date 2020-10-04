/*
Write a C# program to check if a string starts with a specified word.
    Note: Suppose the sentence starts with "Hello"
    Sample Data: string1 = "Hello how are you?"
    Result: Hello.
    Sample Output:
    Input a string : Hello how are you?
    True
*/
using System;

namespace Exercice_34
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordToCheck = "Hello";
            string userInput = String.Empty;

            Console.WriteLine("Check if a string starts with a specified word.");
            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            Console.WriteLine(userInput.StartsWith(wordToCheck));
        }
    }
}
