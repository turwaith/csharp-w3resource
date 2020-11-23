/*
Write a C# Sharp program to check whether a given string starts with "F" or ends with "B".
If the string starts with "F" return "Fizz" and return "Buzz" if it ends with "B".
If the string starts with "F" and ends with "B" return "FizzBuzz". 
In other cases return the original string
*/
using System;

namespace Exercice_46
{
    class Program
    {
        public static string FizzBuzz(string userInput)
        {
            if(userInput.StartsWith('F') && userInput.EndsWith('B')) return "FizzBuzz";
            else if(userInput.StartsWith('F')) return "Fizz";
            else if(userInput.EndsWith('B')) return "Buzz";
            else return userInput;
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine(@"Check whether a given string starts with ""F"" or ends with ""B"".
If the string starts with ""F"" return ""Fizz"" and return ""Buzz"" if it ends with ""B""
If the string starts with ""F"" and ends with ""B"" return ""FizzBuzz"".
In other cases return the original string");
        
            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();

            Console.WriteLine($"Output: {FizzBuzz(userInput)}");
        }
    }
}
