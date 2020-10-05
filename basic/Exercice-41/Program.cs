/*
Write a C# program to check if a given string contains ‘w’ character between 1 and 3 times. 
Test Data:
    Input a string (conatins at least one 'w' char) : w3resource
    Test the string contains 'w' character between 1 and 3 times:
    Sample Output
    True
*/
using System;
using System.Linq;

namespace Exercice_41
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput = String.Empty;
            bool isBetween = false;

            Console.WriteLine("Test the string contains 'w' character between 1 and 3 times.");
            Console.Write("Input a string (contains at least one 'w' character: ");
            userInput = Console.ReadLine();

            isBetween = userInput.Contains("w") && 
                        userInput.Count(item => item == 'w') >= 1 &&
                        userInput.Count(item => item == 'w') <= 3;

            Console.WriteLine(isBetween);
        }
    }
}
