/*
Write a C# Sharp program to create a new string where 'if' is added to the front of a given string.
If the string already begins with 'if', return the string unchanged.
*/
using System;

namespace Exercice_05
{
    class Program
    {
        private static string NewStringWithIf(string userInput)
        {            
            if(userInput[0..2] == "if") return userInput;
            else return "if " + userInput;
        }
        static void Main(string[] args)
        {
            string userInput = String.Empty;

            Console.WriteLine("Create a new string where 'if' is added to the front of a given string. " +
                              "If the string already begins with 'if', return the string unchanged.");

            Console.Write("Enter your string: ");
            userInput = Console.ReadLine();
            Console.WriteLine(NewStringWithIf(userInput));
        }
    }
}
