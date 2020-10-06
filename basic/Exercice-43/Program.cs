/*
Write a C# program to check if a given string starts with "w" and immediately followed by two "ww".
    Test Data:
    Input a string : www
    Sample Output
    False
*/
using System;

namespace Exercice_43
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            bool userOutput =  false;

            Console.Write("Input a string: ");
            userInput = Console.ReadLine();

            if(userInput.Length >= 5 && userInput.StartsWith("w") && userInput[1..5] == "wwww") userOutput = true;

            Console.WriteLine(userOutput);
        }
    }
}
